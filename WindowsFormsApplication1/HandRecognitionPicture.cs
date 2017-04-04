using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV.Structure;
using Emgu.CV;
using HandGestureRecognition.SkinDetector;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;

namespace WindowsFormsApplication1
{
    public class HandRecognitionPicture
    {
        static IColorSkinDetector skinDetector;

        static Image<Bgr, Byte> currentFrame;
        static Image<Bgr, Byte> currentFrameCopy;

        //static Capture grabber;
        static AdaptiveSkinDetector detector;

        int frameWidth;
        int frameHeight;

        static Hsv hsv_min;
        static Hsv hsv_max;
        static Ycc YCrCb_min;
        static Ycc YCrCb_max;

        static Seq<Point> hull;
        static Seq<Point> filteredHull;
        static Seq<MCvConvexityDefect> defects;
        static MCvConvexityDefect[] defectArray;
        static Rectangle handRect;
        static MCvBox2D box;
        static Ellipse ellip;
        static Image<Bgr, Byte> myimage;

        static List<fingers> frames;

        private struct fingers
        {
            public List<Point> fingertips;
            public List<Point> fingerholes;
        }

        public HandRecognitionPicture(string image_path)
        {
            detector = new AdaptiveSkinDetector(1, AdaptiveSkinDetector.MorphingMethod.NONE);
            hsv_min = new Hsv(0, 45, 0);
            hsv_max = new Hsv(20, 255, 255);
            YCrCb_min = new Ycc(0, 131, 80);
            YCrCb_max = new Ycc(255, 185, 135);
            box = new MCvBox2D();
            ellip = new Ellipse();

            frames = new List<fingers>();
            try
            {
                Bitmap bitmap = new Bitmap(WindowsFormsApplication1.Properties.Resources.abcd);
                myimage = new Image<Bgr, Byte>(bitmap);
                FrameGrabber();
            }
            catch (FileNotFoundException efg)
            {
                MessageBox.Show(efg.Message);
            }
            catch (ArgumentException ef)
            {
                MessageBox.Show(ef.Message);
            }
        }

        static void FrameGrabber()
        {
            currentFrame = myimage;
            if (currentFrame != null)
            {
                currentFrameCopy = currentFrame.Copy();

                // Uncomment if using opencv adaptive skin detector
                //Image<Gray,Byte> skin = new Image<Gray,byte>(currentFrameCopy.Width,currentFrameCopy.Height);                
                //detector.Process(currentFrameCopy, skin);                

                skinDetector = new YCrCbSkinDetector();

                Image<Gray, Byte> skin = skinDetector.DetectSkin(currentFrameCopy, YCrCb_min, YCrCb_max);

                ExtractContourAndHull(skin);

                DrawAndComputeFingersNum();



                write_score();
            }

        }

        private static void ExtractContourAndHull(Image<Gray, byte> skin)
        {
            using (MemStorage storage = new MemStorage())
            {

                Contour<Point> contours = skin.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE, Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_LIST, storage);
                Contour<Point> biggestContour = null;

                Double Result1 = 0;
                Double Result2 = 0;
                while (contours != null)
                {
                    Result1 = contours.Area;
                    if (Result1 > Result2)
                    {
                        Result2 = Result1;
                        biggestContour = contours;
                    }
                    contours = contours.HNext;
                }

                if (biggestContour != null)
                {
                    //currentFrame.Draw(biggestContour, new Bgr(Color.DarkViolet), 2);
                    Contour<Point> currentContour = biggestContour.ApproxPoly(biggestContour.Perimeter * 0.0025, storage);
                    currentFrame.Draw(currentContour, new Bgr(Color.LimeGreen), 2);
                    biggestContour = currentContour;


                    hull = biggestContour.GetConvexHull(Emgu.CV.CvEnum.ORIENTATION.CV_CLOCKWISE);
                    box = biggestContour.GetMinAreaRect();
                    PointF[] points = box.GetVertices();
                    //handRect = box.MinAreaRect();
                    //currentFrame.Draw(handRect, new Bgr(200, 0, 0), 1);

                    Point[] ps = new Point[points.Length];
                    for (int i = 0; i < points.Length; i++)
                        ps[i] = new Point((int)points[i].X, (int)points[i].Y);

                    currentFrame.DrawPolyline(hull.ToArray(), true, new Bgr(200, 125, 75), 2);
                    currentFrame.Draw(new CircleF(new PointF(box.center.X, box.center.Y), 3), new Bgr(200, 125, 75), 2);

                    //ellip.MCvBox2D= CvInvoke.cvFitEllipse2(biggestContour.Ptr);
                    //currentFrame.Draw(new Ellipse(ellip.MCvBox2D), new Bgr(Color.LavenderBlush), 3);

                    PointF center;
                    float radius;
                    //CvInvoke.cvMinEnclosingCircle(biggestContour.Ptr, out  center, out  radius);
                    //currentFrame.Draw(new CircleF(center, radius), new Bgr(Color.Gold), 2);

                    //currentFrame.Draw(new CircleF(new PointF(ellip.MCvBox2D.center.X, ellip.MCvBox2D.center.Y), 3), new Bgr(100, 25, 55), 2);
                    //currentFrame.Draw(ellip, new Bgr(Color.DeepPink), 2);

                    //CvInvoke.cvEllipse(currentFrame, new Point((int)ellip.MCvBox2D.center.X, (int)ellip.MCvBox2D.center.Y), new System.Drawing.Size((int)ellip.MCvBox2D.size.Width, (int)ellip.MCvBox2D.size.Height), ellip.MCvBox2D.angle, 0, 360, new MCvScalar(120, 233, 88), 1, Emgu.CV.CvEnum.LINE_TYPE.EIGHT_CONNECTED, 0);
                    //currentFrame.Draw(new Ellipse(new PointF(box.center.X, box.center.Y), new SizeF(box.size.Height, box.size.Width), box.angle), new Bgr(0, 0, 0), 2);


                    filteredHull = new Seq<Point>(storage);
                    for (int i = 0; i < hull.Total; i++)
                    {
                        if (Math.Sqrt(Math.Pow(hull[i].X - hull[i + 1].X, 2) + Math.Pow(hull[i].Y - hull[i + 1].Y, 2)) > box.size.Width / 10)
                        {
                            filteredHull.Push(hull[i]);
                        }
                    }

                    defects = biggestContour.GetConvexityDefacts(storage, Emgu.CV.CvEnum.ORIENTATION.CV_CLOCKWISE);

                    defectArray = defects.ToArray();
                }
            }
        }

        private static void DrawAndComputeFingersNum()
        {
            int fingerNum = 0;

            #region hull drawing
            //for (int i = 0; i < filteredHull.Total; i++)
            //{
            //    PointF hullPoint = new PointF((float)filteredHull[i].X,
            //                                  (float)filteredHull[i].Y);
            //    CircleF hullCircle = new CircleF(hullPoint, 4);
            //    currentFrame.Draw(hullCircle, new Bgr(Color.Aquamarine), 2);
            //}
            #endregion

            #region defects drawing
            fingers new_finger;
            new_finger.fingertips = new List<Point>();
            new_finger.fingerholes = new List<Point>();

            for (int i = 0; i < defects.Total; i++)
            {
                PointF startPoint = new PointF((float)defectArray[i].StartPoint.X,
                                                (float)defectArray[i].StartPoint.Y);

                PointF depthPoint = new PointF((float)defectArray[i].DepthPoint.X,
                                                (float)defectArray[i].DepthPoint.Y);

                PointF endPoint = new PointF((float)defectArray[i].EndPoint.X,
                                                (float)defectArray[i].EndPoint.Y);

                LineSegment2D startDepthLine = new LineSegment2D(defectArray[i].StartPoint, defectArray[i].DepthPoint);

                LineSegment2D depthEndLine = new LineSegment2D(defectArray[i].DepthPoint, defectArray[i].EndPoint);

                CircleF startCircle = new CircleF(startPoint, 5f);

                CircleF depthCircle = new CircleF(depthPoint, 5f);

                CircleF endCircle = new CircleF(endPoint, 5f);

                //Custom heuristic based on some experiment, double check it before use
                if ((startCircle.Center.Y < box.center.Y || depthCircle.Center.Y < box.center.Y) && (startCircle.Center.Y < depthCircle.Center.Y) && (Math.Sqrt(Math.Pow(startCircle.Center.X - depthCircle.Center.X, 2) + Math.Pow(startCircle.Center.Y - depthCircle.Center.Y, 2)) > box.size.Height / 6.5))
                {
                    fingerNum++;
                    currentFrame.Draw(startDepthLine, new Bgr(Color.Green), 2);
                    //currentFrame.Draw(depthEndLine, new Bgr(Color.Magenta), 2);
                }


                currentFrame.Draw(startCircle, new Bgr(Color.Red), 2);
                currentFrame.Draw(depthCircle, new Bgr(Color.Yellow), 5);
                //currentFrame.Draw(endCircle, new Bgr(Color.DarkBlue), 4);

                new_finger.fingertips.Add(new Point(defectArray[i].StartPoint.X, defectArray[i].StartPoint.Y));
                new_finger.fingerholes.Add(new Point(defectArray[i].DepthPoint.X, defectArray[i].DepthPoint.Y));
            }
            frames.Add(new_finger);
            #endregion

            MCvFont font = new MCvFont(Emgu.CV.CvEnum.FONT.CV_FONT_HERSHEY_DUPLEX, 5d, 5d);
            currentFrame.Draw(fingerNum.ToString(), ref font, new Point(50, 150), new Bgr(Color.White));



        }

        private static void write_score()
        {
            using (XmlWriter writer = XmlWriter.Create("point.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("hand");

                foreach (fingers finger in frames)
                {
                    writer.WriteStartElement("frame");

                    int min_tip_x = finger.fingertips.Min(c => c.X);
                    int min_tip_y = finger.fingertips.Min(c => c.Y);

                    int min_hole_x = finger.fingerholes.Min(c => c.X);
                    int min_hole_y = finger.fingerholes.Min(c => c.Y);

                    foreach (Point _point in finger.fingertips)
                    {
                        _point.Offset(-min_tip_x, -min_tip_y);
                        writer.WriteStartElement("fingertip");
                        writer.WriteElementString("x", _point.X.ToString());
                        writer.WriteElementString("y", _point.Y.ToString());
                        writer.WriteEndElement();
                    }

                    foreach (Point _point in finger.fingerholes)
                    {
                        _point.Offset(-min_hole_x, -min_hole_y);
                        writer.WriteStartElement("fingerhole");
                        writer.WriteElementString("x", _point.X.ToString());
                        writer.WriteElementString("y", _point.Y.ToString());
                        writer.WriteEndElement();
                    }

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }
}

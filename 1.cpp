<<<<<<< HEAD
#include <iostream>
#include <opencv2/opencv.hpp>
#include "opencv2/imgproc/imgproc.hpp"
#include "opencv2/highgui/highgui.hpp"
#include <stdlib.h>
#include <stdio.h>


using namespace std;
using namespace cv;


/* @ function main */
int main(int argc, char* argv[])
{
    // open the default camera
    cv::VideoCapture cap(0);

    // check if we succeeded
    if (!cap.isOpened()) {
        std::cerr << "Could not open camera" << std::endl;
        return -1;
    }

    // create a window
    cv::namedWindow("webcam", 1);

    // face detection configuration
    cv::CascadeClassifier face_classifier;

    face_classifier.load("C:/opencv/sources/data/haarcascades/haarcascade_frontalface_default.xml");

    cv::Mat frame;

    for (; ; ) {
        bool frame_valid = true;

        try {

            // get a new frame from webcam
            cap >> frame;

        }
        catch (cv::Exception& e) {

            std::cerr << "Exception occurred. Ignoring frame... " << e.err << std::endl;
            frame_valid = false;

        }

        if (frame_valid) {
            try {
                // convert captured frame to gray scale & equalize
                cv::Mat grayframe;
                cv::cvtColor(frame, grayframe, COLOR_RGB2GRAY);
                cv::equalizeHist(grayframe, grayframe);

                // -------------------------------------------------------------
                // face detection routine

                // a vector array to store the face found
                std::vector<cv::Rect> faces;

                face_classifier.detectMultiScale(grayframe, faces,
                    1.1, // increase search scale by 10% each pass
                    3,   // merge groups of three detections
                    1,
                    cv::Size(30, 30)
                );

                // -------------------------------------------------------------
                // draw the results
                for (int i = 0; i < faces.size(); i++) {
                    cv::Point lb(faces[i].x + faces[i].width, faces[i].y + faces[i].height);
                    cv::Point tr(faces[i].x, faces[i].y);

                    cv::rectangle(frame, lb, tr, cv::Scalar(0, 255, 0), 3, 4, 0);
                }

                // print the output
                cv::imshow("webcam", frame);

            }
            catch (cv::Exception& e) {
                std::cerr << "Exception occurred. Ignoring frame... " << e.err << std::endl;
            }
        }

        if (cv::waitKey(30) >= 0) break;
    }

    // VideoCapture automatically deallocate camera object
    return 0;
=======
#include <iostream>
#include <opencv2/opencv.hpp>
#include "opencv2/imgproc/imgproc.hpp"
#include "opencv2/highgui/highgui.hpp"
#include <stdlib.h>
#include <stdio.h>


using namespace std;
using namespace cv;


/* @ function main */
int main(int argc, char* argv[])
{
    // open the default camera
    cv::VideoCapture cap(0);

    // check if we succeeded
    if (!cap.isOpened()) {
        std::cerr << "Could not open camera" << std::endl;
        return -1;
    }

    // create a window
    cv::namedWindow("webcam", 1);

    // face detection configuration
    cv::CascadeClassifier face_classifier;

    face_classifier.load("C:/opencv/sources/data/haarcascades/haarcascade_frontalface_default.xml");

    cv::Mat frame;

    for (; ; ) {
        bool frame_valid = true;

        try {

            // get a new frame from webcam
            cap >> frame;

        }
        catch (cv::Exception& e) {

            std::cerr << "Exception occurred. Ignoring frame... " << e.err << std::endl;
            frame_valid = false;

        }

        if (frame_valid) {
            try {
                // convert captured frame to gray scale & equalize
                cv::Mat grayframe;
                cv::cvtColor(frame, grayframe, COLOR_RGB2GRAY);
                cv::equalizeHist(grayframe, grayframe);

                // -------------------------------------------------------------
                // face detection routine

                // a vector array to store the face found
                std::vector<cv::Rect> faces;

                face_classifier.detectMultiScale(grayframe, faces,
                    1.1, // increase search scale by 10% each pass
                    3,   // merge groups of three detections
                    1,
                    cv::Size(30, 30)
                );

                // -------------------------------------------------------------
                // draw the results
                for (int i = 0; i < faces.size(); i++) {
                    cv::Point lb(faces[i].x + faces[i].width, faces[i].y + faces[i].height);
                    cv::Point tr(faces[i].x, faces[i].y);

                    cv::rectangle(frame, lb, tr, cv::Scalar(0, 255, 0), 3, 4, 0);
                }

                // print the output
                cv::imshow("webcam", frame);

            }
            catch (cv::Exception& e) {
                std::cerr << "Exception occurred. Ignoring frame... " << e.err << std::endl;
            }
        }

        if (cv::waitKey(30) >= 0) break;
    }

    // VideoCapture automatically deallocate camera object
    return 0;
>>>>>>> ed7c0bc149a795d06878c994a7ea02d1eaa6664a
}
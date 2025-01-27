﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    public static class Matrix
    {

        public static double[,] Laplacian3x3
        {
            get
            {
                return new double[,]  
                { { -1, -1, -1,  }, 
                  { -1,  8, -1,  }, 
                  { -1, -1, -1,  }, };
            }
        }

        public static double[,] Laplacian5x5
        {
            get
            {
                return new double[,] 
                { { -1, -1, -1, -1, -1, }, 
                  { -1, -1, -1, -1, -1, }, 
                  { -1, -1, 24, -1, -1, }, 
                  { -1, -1, -1, -1, -1, }, 
                  { -1, -1, -1, -1, -1  }, };
            }
        }

        public static double[,] LaplacianOfGaussian
        {
            get
            {
                return new double[,]  
                { {  0,   0, -1,  0,  0 }, 
                  {  0,  -1, -2, -1,  0 }, 
                  { -1,  -2, 16, -2, -1 },
                  {  0,  -1, -2, -1,  0 },
                  {  0,   0, -1,  0,  0 }, };
            }
        }

        public static double[,] Gaussian3x3
        {
            get
            {
                return new double[,]  
                { { 1, 2, 1, }, 
                  { 2, 4, 2, }, 
                  { 1, 2, 1, }, };
            }
        }

        public static double[,] Gaussian5x5Type1
        {
            get
            {
                return new double[,]  
                { { 2, 04, 05, 04, 2 }, 
                  { 4, 09, 12, 09, 4 }, 
                  { 5, 12, 15, 12, 5 },
                  { 4, 09, 12, 09, 4 },
                  { 2, 04, 05, 04, 2 }, };
            }
        }

        public static double[,] Gaussian5x5Type2
        {
            get
            {
                return new double[,] 
                { {  1,   4,  6,  4,  1 }, 
                  {  4,  16, 24, 16,  4 }, 
                  {  6,  24, 36, 24,  6 },
                  {  4,  16, 24, 16,  4 },
                  {  1,   4,  6,  4,  1 }, };
            }
        }

        public static double[,] Sobel3x3Horizontal
        {
            get
            {
                return new double[,] 
                { { -1,  0,  1, }, 
                  { -2,  0,  2, }, 
                  { -1,  0,  1, }, };
            }
        }

        public static double[,] Sobel3x3Vertical
        {
            get
            {
                return new double[,] 
                { {  1,  2,  1, }, 
                  {  0,  0,  0, }, 
                  { -1, -2, -1, }, };
            }
        }

        public static double[,] Roberts2x2Horizontal
        {
            get
            {
                return new double[,]  
                { { -1, 0, },         
                  {  0, -1,}, };
            }
        }
        public static double[,] Roberts2x2Vertical
        {
            get
            {
                return new double[,]  
                { { 0, -1, },         
                  {  1, 0, }, };
            }
        }

        public static double[,] Prewitt3x3Horizontal
        {
            get
            {
                return new double[,] 
                { { -1,  0,  1, }, 
                  { -1,  0,  1, }, 
                  { -1,  0,  1, }, };
            }
        }

        public static double[,] Prewitt3x3Vertical
        {
            get
            {
                return new double[,] 
                { {  1,  1,  1, }, 
                  {  0,  0,  0, }, 
                  { -1, -1, -1, }, };
            }
        }


        public static double[,] Kirsch3x3Horizontal
        {
            get
            {
                return new double[,] 
                { {  5,  5,  5, }, 
                  { -3,  0, -3, }, 
                  { -3, -3, -3, }, };
            }
        }

        public static double[,] Kirsch3x3Vertical
        {
            get
            {
                return new double[,] 
                { {  5, -3, -3, }, 
                  {  5,  0, -3, }, 
                  {  5, -3, -3, }, };
            }
        }
        public static double[,] Mean3x3
        {
            get
            {
                return new double[,]  
                { { 1, 1, 1, }, 
                  { 1, 1, 1, }, 
                  { 1, 1, 1, }, };
            }
        }

        public static double[,] Mean5x5
        {
            get
            {
                return new double[,]  
                { { 1, 1, 1, 1, 1}, 
                  { 1, 1, 1, 1, 1},
                  { 1, 1, 1, 1, 1},
                  { 1, 1, 1, 1, 1},
                  { 1, 1, 1, 1, 1}, };
            }
        }

        public static double[,] Mean7x7
        {
            get
            {
                return new double[,]  
                { { 1, 1, 1, 1, 1, 1, 1}, 
                  { 1, 1, 1, 1, 1, 1, 1},
                  { 1, 1, 1, 1, 1, 1, 1},
                  { 1, 1, 1, 1, 1, 1, 1},
                  { 1, 1, 1, 1, 1, 1, 1},
                  { 1, 1, 1, 1, 1, 1, 1},
                  { 1, 1, 1, 1, 1, 1, 1}, };
            }
        }

        public static double[,] Mean9x9
        {
            get
            {
                return new double[,]  
                { { 1, 1, 1, 1, 1, 1, 1, 1, 1}, 
                  { 1, 1, 1, 1, 1, 1, 1, 1, 1},
                  { 1, 1, 1, 1, 1, 1, 1, 1, 1},
                  { 1, 1, 1, 1, 1, 1, 1, 1, 1},
                  { 1, 1, 1, 1, 1, 1, 1, 1, 1},
                  { 1, 1, 1, 1, 1, 1, 1, 1, 1},
                  { 1, 1, 1, 1, 1, 1, 1, 1, 1},
                  { 1, 1, 1, 1, 1, 1, 1, 1, 1},
                  { 1, 1, 1, 1, 1, 1, 1, 1, 1}, };
            }
        }

        public static double[,] GaussianBlur3x3
        {
            get
            {
                return new double[,]  
                { { 1, 2, 1, }, 
                  { 2, 4, 2, }, 
                  { 1, 2, 1, }, };
            }
        }

        public static double[,] GaussianBlur5x5
        {
            get
            {
                return new double[,]  
                { { 2, 04, 05, 04, 2 }, 
                  { 4, 09, 12, 09, 4 }, 
                  { 5, 12, 15, 12, 5 },
                  { 4, 09, 12, 09, 4 },
                  { 2, 04, 05, 04, 2 }, };
            }
        }

        public static double[,] MotionBlur5x5
        {
            get
            {
                return new double[,]  
                { { 1, 0, 0, 0, 1}, 
                  { 0, 1, 0, 1, 0}, 
                  { 0, 0, 1, 0, 0},
                  { 0, 1, 0, 1, 0},
                  { 1, 0, 0, 0, 1}, };
            }
        }

        public static double[,] MotionBlur5x5At45Degrees
        {
            get
            {
                return new double[,]  
                { { 0, 0, 0, 0, 1}, 
                  { 0, 0, 0, 1, 0}, 
                  { 0, 0, 1, 0, 0},
                  { 0, 1, 0, 0, 0},
                  { 1, 0, 0, 0, 0}, };
            }
        }

        public static double[,] MotionBlur5x5At135Degrees
        {
            get
            {
                return new double[,]  
                { { 1, 0, 0, 0, 0}, 
                  { 0, 1, 0, 0, 0}, 
                  { 0, 0, 1, 0, 0},
                  { 0, 0, 0, 1, 0},
                  { 0, 0, 0, 0, 1}, };
            }
        }

        public static double[,] MotionBlur7x7
        {
            get
            {
                return new double[,]  
                { { 1, 0, 0, 0, 0, 0, 1}, 
                  { 0, 1, 0, 0, 0, 1, 0}, 
                  { 0, 0, 1, 0, 1, 0, 0},
                  { 0, 0, 0, 1, 0, 0, 0},
                  { 0, 0, 1, 0, 1, 0, 0},
                  { 0, 1, 0, 0, 0, 1, 0},
                  { 1, 0, 0, 0, 0, 0, 1}, };
            }
        }

        public static double[,] MotionBlur7x7At45Degrees
        {
            get
            {
                return new double[,]  
                { { 0, 0, 0, 0, 0, 0, 1}, 
                  { 0, 0, 0, 0, 0, 1, 0}, 
                  { 0, 0, 0, 0, 1, 0, 0},
                  { 0, 0, 0, 1, 0, 0, 0},
                  { 0, 0, 1, 0, 0, 0, 0},
                  { 0, 1, 0, 0, 0, 0, 0},
                  { 1, 0, 0, 0, 0, 0, 0}, };
            }
        }

        public static double[,] MotionBlur7x7At135Degrees
        {
            get
            {
                return new double[,]  
                { { 1, 0, 0, 0, 0, 0, 0}, 
                  { 0, 1, 0, 0, 0, 0, 0}, 
                  { 0, 0, 1, 0, 0, 0, 0},
                  { 0, 0, 0, 1, 0, 0, 0},
                  { 0, 0, 0, 0, 1, 0, 0},
                  { 0, 0, 0, 0, 0, 1, 0},
                  { 0, 0, 0, 0, 0, 0, 1}, };
            }
        }

        public static double[,] MotionBlur9x9
        {
            get
            {
                return new double[,]  
                { {1, 0, 0, 0, 0, 0, 0, 0, 1,},
                  {0, 1, 0, 0, 0, 0, 0, 1, 0,},
                  {0, 0, 1, 0, 0, 0, 1, 0, 0,},
                  {0, 0, 0, 1, 0, 1, 0, 0, 0,},
                  {0, 0, 0, 0, 1, 0, 0, 0, 0,},
                  {0, 0, 0, 1, 0, 1, 0, 0, 0,},
                  {0, 0, 1, 0, 0, 0, 1, 0, 0,},
                  {0, 1, 0, 0, 0, 0, 0, 1, 0,},
                  {1, 0, 0, 0, 0, 0, 0, 0, 1,}, };
            }
        }

        public static double[,] MotionBlur9x9At45Degrees
        {
            get
            {
                return new double[,]  
                { {0, 0, 0, 0, 0, 0, 0, 0, 1,},
                  {0, 0, 0, 0, 0, 0, 0, 1, 0,},
                  {0, 0, 0, 0, 0, 0, 1, 0, 0,},
                  {0, 0, 0, 0, 0, 1, 0, 0, 0,},
                  {0, 0, 0, 0, 1, 0, 0, 0, 0,},
                  {0, 0, 0, 1, 0, 0, 0, 0, 0,},
                  {0, 0, 1, 0, 0, 0, 0, 0, 0,},
                  {0, 1, 0, 0, 0, 0, 0, 0, 0,},
                  {1, 0, 0, 0, 0, 0, 0, 0, 0,}, };
            }
        }

        public static double[,] MotionBlur9x9At135Degrees
        {
            get
            {
                return new double[,]  
                { {1, 0, 0, 0, 0, 0, 0, 0, 0,},
                  {0, 1, 0, 0, 0, 0, 0, 0, 0,},
                  {0, 0, 1, 0, 0, 0, 0, 0, 0,},
                  {0, 0, 0, 1, 0, 0, 0, 0, 0,},
                  {0, 0, 0, 0, 1, 0, 0, 0, 0,},
                  {0, 0, 0, 0, 0, 1, 0, 0, 0,},
                  {0, 0, 0, 0, 0, 0, 1, 0, 0,},
                  {0, 0, 0, 0, 0, 0, 0, 1, 0,},
                  {0, 0, 0, 0, 0, 0, 0, 0, 1,}, };
            }
        }
    }
}

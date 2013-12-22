// MathFuncsDll.h


//#ifdef MATHFUNCSDLL_EXPORTS
//	#define MATHFUNCSDLL_API __declspec(dllexport) 
//#else
//	#define MATHFUNCSDLL_API __declspec(dllimport) 
//#endif

namespace MathFuncs
{
    // This class is exported from the MathFuncsDll.dll
    class MyMathFuncs
    {
    //public: 
        // Returns a + b
        static double __stdcall MyCalcAdd(double a, double b); 

        // Returns a - b
        static double __stdcall MyCalcSubtract(double a, double b); 

        // Returns a * b
        static double __stdcall MyCalcMultiply(double a, double b); 

        // Returns a / b
        // Throws const std::invalid_argument& if b is 0
        static double __stdcall MyCalcDivide(double a, double b); 
    };
}

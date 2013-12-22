// MathFuncsDll.cpp : DLL �A�v���P�[�V�����p�ɃG�N�X�|�[�g�����֐����`���܂��B
//

#include "stdafx.h"
#include "MathFuncsDll.h"
#include <stdexcept>

using namespace std;

namespace MathFuncs
{
	double MyMathFuncs::MyCalcAdd(double a, double b)
	{
		return a + b;
	}

	double MyMathFuncs::MyCalcSubtract(double a, double b)
	{
		return a - b;
	}

	double MyMathFuncs::MyCalcMultiply(double a, double b)
    {
        return a * b;
    }

    double MyMathFuncs::MyCalcDivide(double a, double b)
    {
        if (b == 0)
        {
            throw invalid_argument("b cannot be zero!");
        }

        return a / b;
    }
}


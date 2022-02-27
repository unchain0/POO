using _221._Introdução_a_delegates.Services;

double a = 10;
double b = 12;

BinaryNumericOperation op = CalculationService.ShowSum;
op += CalculationService.ShowMax;

op(a, b);

internal delegate void BinaryNumericOperation(double n1, double n2);

// 1 den 10 a kadar olan sayıların küplerinin toplamını veren uygulama
double sum = 0;
for(int i=1; i<=10; i++){
    sum += Math.Pow(i,3);
}
Console.WriteLine(sum);

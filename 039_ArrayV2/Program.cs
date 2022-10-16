// See https://aka.ms/new-console-template for more information
int[] CreateMas(){
    int kol = 12;
    int[] arr = new int[12];
    int kol_pol = 0;
    int kol_otrc = 0;
    while (kol_pol!=6 && kol_otrc!=6){
        kol_pol = 0;
        kol_otrc = 0;
        for(int i = 0;i<kol;i++){
            arr[i] = new Random().Next(-10,10);
            if (arr[i]>0)kol_pol++;
            else if(arr[i]<0)kol_otrc++;
            else i--;//РµСЃР»Рё С‡РёСЃР»Рѕ СЂР°РІРЅРѕ 0, С‚Рѕ РїСЂРѕРїСѓСЃРєР°РµРј
        }
    }
    Console.WriteLine($"Количество положительных чисел: {kol_pol}"); 
    Console.WriteLine($"Количество отрицательных чисел: {kol_otrc}"); 
    return arr;
}
void Print(int[] arr){
    Console.WriteLine(String.Join(" ",arr));
}
int[] arr = new int[12];
arr = CreateMas();
Print(arr);
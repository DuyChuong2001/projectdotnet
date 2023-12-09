using System;

class Program
{
    static int Fibonanci(int n){
        if (n <= 1){
            return 1;
        }
        int a = 0, b = 1, tong = 0;
        for (int i = 2; i <= n; i++){
            tong = a + b;
            a = b;
            b = tong;
        }
        return b;
    }
    static void BangCuuChuong(int n){
        for (int i = 1; i <= n; i++){
            Console.WriteLine("Cuu chuong {0}: ",i);
            for (int j = 2; j <= 9; j++){
                Console.WriteLine("{0} * {1} = {2}", i,j,i*j);
            }
        }
    }
    static int TongGiaiThua(int n){
        int tong = 1;
        for (int i = 1; i<= n; i++){
            tong = tong * i;
        }
        return tong;
    }
    static void SoChinhPhuong(int n){
        int flask = 0;
        for (int i = 1; i <= Math.Sqrt(n); i++){
            if (i * i == n){
                flask = 1;
                break;
            }
        }
        if (flask == 1) {
            Console.WriteLine("{0} la so chinh phuong", n);
        }
        else Console.WriteLine("{0} khong la so chinh phuong", n);
    }
    static void SoNgayTrongThang(int thang){
        switch (thang)
        {
            case 2:
                Console.WriteLine("Thang 2 co 28 ngay");
                break;
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.WriteLine("Thang {0} co 31 ngay", thang);
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                Console.WriteLine("Thang {0} co 30 ngay", thang);
                break;
            default:
                Console.WriteLine("Khong co thang {0}", thang);
                break;
        }
    }
    static int TongSoNguyenS(int n){
        int tong = 1;
        for(int i = 2; i <= n; i++){
            tong = tong + i * i;
        }
        return tong;
    }
    static int TongSoLe(int n){
        int tong = 0;
        for(int i = 1; i <= n; i++){
            if(i % 2 != 0){
                tong = tong + i;
            }
        }
        return tong;
    }
    static void SoNguyenTo(int n){
        for (int i = 2; i <= n; i++){
            if (IsPrime(i)){
                Console.WriteLine(i);
            }
        }
    }

    static bool IsPrime(int n){
        if (n < 2){
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(n); i++){
            if (n % i == 0){
                return false;
            }
        }
        return true;
    }
    static void TamGiacNguoc(int chieucao){
        for( int i = 1; i <= chieucao; i++){
            for( int j = i; j < chieucao; j++){
                Console.Write("*");
            }
            Console.WriteLine("*");
        }
    }
    static void TamGiac(int chieucao){
        for( int i = chieucao; i >= 1; i--){
            for( int j = chieucao; j > i; j--){
                Console.Write("*");
            }
            Console.WriteLine("*");
        }
    }
    static void TamGiacDeu(int chieucao){
        for( int i = 1; i <= chieucao; i++){
            for( int j = 1; j <= chieucao - i; j++){
                Console.Write(" ");
            }
            for(int k = 1; k <= 2 * i - 1; k++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    static void TamGiacDeuNguoc(int chieucao){
        for( int i = chieucao; i >= 1; i--){
            for( int j = chieucao - i; j >= 1; j--){
                Console.Write(" ");
            }
            for(int k = 1; k <= 2 * i - 1; k++){
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    static void Main(){
        int n = int.Parse(Console.ReadLine());
        // #1
        // if (n % 3 == 0){
        //     Console.WriteLine("{0} chia het cho 3", n);
        // }
        // else Console.WriteLine("n khong chia het cho 3");
        // #2
        // BangCuuChuong(n);
        // #3
        // Console.WriteLine("Tong giai thua {0}", TongGiaiThua(n));
        // #4
        // SoChinhPhuong(n);
        // #5
        // SoNgayTrongThang(n);
        // #6
        // Console.WriteLine("Tong so nguyen S: {0}", TongSoNguyenS(n));
        // #7
        // Console.WriteLine("Tong so le: {0}", TongSoLe(n));
        // #8
        // SoNguyenTo(n);
        // #9
        // TamGiac(n);
        // TamGiacNguoc(n);
        // TamGiacDeu(n);
        // TamGiacDeuNguoc(n);
        // #10
        // for (int i = 1; i <= n; i++){
        //     Console.WriteLine(Fibonanci(i));
        // }
    }
}


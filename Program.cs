

using System.Runtime.InteropServices;

// Just testing :)

void PrintSize<T>() where T : unmanaged
{
    T a = new T();
    Console.WriteLine(a.GetType().Name + " is " + Marshal.SizeOf<T>() + "bytes and " + Marshal.SizeOf<T>() * 8 + "bits");
}

PrintSize<float>();
PrintSize<double>();
PrintSize<decimal>();
PrintSize<char>();
PrintSize<bool>();
PrintSize<int>();
PrintSize<long>();

Console.ReadLine();
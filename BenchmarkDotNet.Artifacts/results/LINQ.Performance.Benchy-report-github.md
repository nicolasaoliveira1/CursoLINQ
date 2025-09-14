```

BenchmarkDotNet v0.15.2, Windows 10 (10.0.19045.5737/22H2/2022Update)
Intel Core i5-10400 CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.412
  [Host]     : .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.18 (8.0.1825.31117), X64 RyuJIT AVX2


```
| Method                       | Mean     | Error   | StdDev  |
|----------------------------- |---------:|--------:|--------:|
| FindPersonWithAny            | 191.2 ns | 0.54 ns | 0.45 ns |
| FindPersonWithFirstOrDefault | 105.3 ns | 1.44 ns | 1.35 ns |

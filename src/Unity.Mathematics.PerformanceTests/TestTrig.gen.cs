//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated. To update the generation of this file, modify and re-run Unity.Mathematics.CodeGen.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using NUnit.Framework;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.PerformanceTesting;
using Unity.Mathematics.Geometry;
using Unity.Burst;

namespace Unity.Mathematics.PerformanceTests
{
    partial class TestTrig
    {
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class float_sincos
        {
            public const int iterations = 10000;

            public struct Arguments : IDisposable
            {
                public float* sin;
                public float* cos;

                public void Init()
                {
                    sin = (float*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float>() * iterations, UnsafeUtility.AlignOf<float>(), Allocator.Persistent);
                    for (int i = 0; i < iterations; ++i)
                    {
                        sin[i] = 0.0f;
                    }

                    cos = (float*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float>() * iterations, UnsafeUtility.AlignOf<float>(), Allocator.Persistent);
                    for (int i = 0; i < iterations; ++i)
                    {
                        cos[i] = 1.0f;
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(sin, Allocator.Persistent);
                    UnsafeUtility.Free(cos, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < iterations; ++i)
                {
                    math.sincos(args.sin[i], out args.sin[i], out args.cos[i]);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile(CompileSynchronously = true)]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void float_sincos_mono()
        {
            float_sincos.TestFunction testFunction = float_sincos.MonoTestFunction;
            var args = new float_sincos.Arguments();
            args.Init();

            var monoSampleGroup = new SampleGroup("Mono", SampleUnit.Microsecond);            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .SampleGroup(monoSampleGroup)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }

        [Test, Performance]
        public void float_sincos_burst()
        {
            FunctionPointer<float_sincos.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<float_sincos.TestFunction>(float_sincos.BurstTestFunction);
            var args = new float_sincos.Arguments();
            args.Init();

            var burstSampleGroup = new SampleGroup("Burst", SampleUnit.Microsecond);            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .SampleGroup(burstSampleGroup)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class float2_sincos
        {
            public const int iterations = 10000;

            public struct Arguments : IDisposable
            {
                public float2* sin;
                public float2* cos;

                public void Init()
                {
                    sin = (float2*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float2>() * iterations, UnsafeUtility.AlignOf<float2>(), Allocator.Persistent);
                    for (int i = 0; i < iterations; ++i)
                    {
                        sin[i] = new float2(0.0f);
                    }

                    cos = (float2*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float2>() * iterations, UnsafeUtility.AlignOf<float2>(), Allocator.Persistent);
                    for (int i = 0; i < iterations; ++i)
                    {
                        cos[i] = new float2(1.0f);
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(sin, Allocator.Persistent);
                    UnsafeUtility.Free(cos, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < iterations; ++i)
                {
                    math.sincos(args.sin[i], out args.sin[i], out args.cos[i]);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile(CompileSynchronously = true)]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void float2_sincos_mono()
        {
            float2_sincos.TestFunction testFunction = float2_sincos.MonoTestFunction;
            var args = new float2_sincos.Arguments();
            args.Init();

            var monoSampleGroup = new SampleGroup("Mono", SampleUnit.Microsecond);            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .SampleGroup(monoSampleGroup)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }

        [Test, Performance]
        public void float2_sincos_burst()
        {
            FunctionPointer<float2_sincos.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<float2_sincos.TestFunction>(float2_sincos.BurstTestFunction);
            var args = new float2_sincos.Arguments();
            args.Init();

            var burstSampleGroup = new SampleGroup("Burst", SampleUnit.Microsecond);            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .SampleGroup(burstSampleGroup)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class float3_sincos
        {
            public const int iterations = 10000;

            public struct Arguments : IDisposable
            {
                public float3* sin;
                public float3* cos;

                public void Init()
                {
                    sin = (float3*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float3>() * iterations, UnsafeUtility.AlignOf<float3>(), Allocator.Persistent);
                    for (int i = 0; i < iterations; ++i)
                    {
                        sin[i] = new float3(0.0f);
                    }

                    cos = (float3*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float3>() * iterations, UnsafeUtility.AlignOf<float3>(), Allocator.Persistent);
                    for (int i = 0; i < iterations; ++i)
                    {
                        cos[i] = new float3(1.0f);
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(sin, Allocator.Persistent);
                    UnsafeUtility.Free(cos, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < iterations; ++i)
                {
                    math.sincos(args.sin[i], out args.sin[i], out args.cos[i]);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile(CompileSynchronously = true)]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void float3_sincos_mono()
        {
            float3_sincos.TestFunction testFunction = float3_sincos.MonoTestFunction;
            var args = new float3_sincos.Arguments();
            args.Init();

            var monoSampleGroup = new SampleGroup("Mono", SampleUnit.Microsecond);            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .SampleGroup(monoSampleGroup)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }

        [Test, Performance]
        public void float3_sincos_burst()
        {
            FunctionPointer<float3_sincos.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<float3_sincos.TestFunction>(float3_sincos.BurstTestFunction);
            var args = new float3_sincos.Arguments();
            args.Init();

            var burstSampleGroup = new SampleGroup("Burst", SampleUnit.Microsecond);            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .SampleGroup(burstSampleGroup)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }
        [BurstCompile(CompileSynchronously = true)]
        public unsafe class float4_sincos
        {
            public const int iterations = 10000;

            public struct Arguments : IDisposable
            {
                public float4* sin;
                public float4* cos;

                public void Init()
                {
                    sin = (float4*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float4>() * iterations, UnsafeUtility.AlignOf<float4>(), Allocator.Persistent);
                    for (int i = 0; i < iterations; ++i)
                    {
                        sin[i] = new float4(0.0f);
                    }

                    cos = (float4*)UnsafeUtility.Malloc(UnsafeUtility.SizeOf<float4>() * iterations, UnsafeUtility.AlignOf<float4>(), Allocator.Persistent);
                    for (int i = 0; i < iterations; ++i)
                    {
                        cos[i] = new float4(1.0f);
                    }

                }

                public void Dispose()
                {
                    UnsafeUtility.Free(sin, Allocator.Persistent);
                    UnsafeUtility.Free(cos, Allocator.Persistent);
                }
            }

            public static void CommonTestFunction(ref Arguments args)
            {
                for (int i = 0; i < iterations; ++i)
                {
                    math.sincos(args.sin[i], out args.sin[i], out args.cos[i]);
                }
            }

            public static void MonoTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            [BurstCompile(CompileSynchronously = true)]
            public static void BurstTestFunction(ref Arguments args)
            {
                CommonTestFunction(ref args);
            }

            public delegate void TestFunction(ref Arguments args);
        }

        [Test, Performance]
        public void float4_sincos_mono()
        {
            float4_sincos.TestFunction testFunction = float4_sincos.MonoTestFunction;
            var args = new float4_sincos.Arguments();
            args.Init();

            var monoSampleGroup = new SampleGroup("Mono", SampleUnit.Microsecond);            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .SampleGroup(monoSampleGroup)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }

        [Test, Performance]
        public void float4_sincos_burst()
        {
            FunctionPointer<float4_sincos.TestFunction> testFunction = BurstCompiler.CompileFunctionPointer<float4_sincos.TestFunction>(float4_sincos.BurstTestFunction);
            var args = new float4_sincos.Arguments();
            args.Init();

            var burstSampleGroup = new SampleGroup("Burst", SampleUnit.Microsecond);            Measure.Method(() =>
            {
                testFunction.Invoke(ref args);
            })
            .SampleGroup(burstSampleGroup)
            .WarmupCount(1)
            .MeasurementCount(10)
            .Run();
            args.Dispose();
        }
    }
}

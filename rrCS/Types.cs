using System;
using Xunit;

namespace rrCS
{
    public class Types
    {

        /// <summary>
        /// 内置类型
        /// </summary>
        [Fact]
        public void BuiltInTypes()
        {
            bool bool8 = default;
            Assert.IsType<Boolean>(bool8);
            Assert.IsAssignableFrom<ValueType>(bool8);
            Assert.Equal(1, sizeof(bool));
            Assert.False(bool8);

            sbyte int8 = default;
            Assert.IsType<SByte>(int8);
            Assert.IsAssignableFrom<ValueType>(int8);
            Assert.Equal(1, sizeof(sbyte));
            Assert.Equal(0, int8);
            short int16 = default;
            Assert.IsType<Int16>(int16);
            Assert.IsAssignableFrom<ValueType>(int16);
            Assert.Equal(2, sizeof(short));
            Assert.Equal(0, int16);
            int int32 = default;
            Assert.IsType<Int32>(int32);
            Assert.IsAssignableFrom<ValueType>(int32);
            Assert.Equal(4, sizeof(int));
            Assert.Equal(0, int32);
            long int64 = default;
            Assert.IsType<Int64>(int64);
            Assert.IsAssignableFrom<ValueType>(int64);
            Assert.Equal(8, sizeof(long));
            Assert.Equal(0L, int64);

            byte uint8 = default;
            Assert.IsType<Byte>(uint8);
            Assert.IsAssignableFrom<ValueType>(uint8);
            Assert.Equal(1, sizeof(byte));
            Assert.Equal(0, uint8);
            ushort uint16 = default;
            Assert.IsType<UInt16>(uint16);
            Assert.IsAssignableFrom<ValueType>(uint16);
            Assert.Equal(2, sizeof(ushort));
            Assert.Equal(0, uint16);
            uint uint32 = default;
            Assert.IsType<UInt32>(uint32);
            Assert.IsAssignableFrom<ValueType>(uint32);
            Assert.Equal(4, sizeof(uint));
            Assert.Equal(0u, uint32);
            ulong uint64 = default;
            Assert.IsType<UInt64>(uint64);
            Assert.IsAssignableFrom<ValueType>(uint64);
            Assert.Equal(8, sizeof(ulong));
            Assert.Equal(0uL, uint64);

            float float32 = default;
            Assert.IsType<Single>(float32);
            Assert.IsAssignableFrom<ValueType>(float32);
            Assert.Equal(4, sizeof(float));
            Assert.Equal(0f, float32);
            double float64 = default;
            Assert.IsType<Double>(float64);
            Assert.IsAssignableFrom<ValueType>(float64);
            Assert.Equal(8, sizeof(double));
            Assert.Equal(0d, float64);
            decimal float128 = default;
            Assert.IsType<Decimal>(float128);
            Assert.IsAssignableFrom<ValueType>(float128);
            Assert.Equal(16, sizeof(decimal));
            Assert.Equal(0m, float128);

            char char16 = default;
            Assert.IsType<Char>(char16);
            Assert.IsAssignableFrom<ValueType>(char16);
            Assert.Equal(2, sizeof(char));
            Assert.Equal('\x0000', char16);

            string stringN = default;
            Assert.Null(stringN);

            object objectN = default;
            Assert.Null(objectN);
        }

        class MyClass { }
        interface IMyInterface { }
        struct MyStruct { }
        enum MyEnum { }

        /// <summary>
        /// 自定义类型
        /// </summary>
        [Fact]
        public void CustomTypes()
        {
            MyClass myClass = default;
            Assert.Null(myClass);
            IMyInterface myInterface = default;
            Assert.Null(myInterface);
            int[] myArray = default;
            Assert.Null(myArray);

            MyStruct myStruct = default;
            Assert.IsAssignableFrom<ValueType>(myStruct);

            MyEnum myEnum = default;
            Assert.Equal(4, sizeof(MyEnum));
            Assert.IsAssignableFrom<Enum>(myEnum);
            Assert.IsAssignableFrom<ValueType>(myEnum);
        }

        /// <summary>
        /// 隐式类型
        /// </summary>
        [Fact]
        public void ImplicitTypes()
        {
            var bool8 = false;
            Assert.IsType<bool>(bool8);
        }

        /// <summary>
        /// 匿名类型
        /// </summary>
        [Fact]
        public void AnonymousTypes()
        {
            var obj = new { Prop = 0 };
            Assert.IsAssignableFrom<System.Object>(obj);
        }

        /// <summary>
        /// 可空类型
        /// </summary>
        [Fact]
        public void NullableTypes()
        {
            int? val = null;
            Assert.Null(val);
        }
    }
}

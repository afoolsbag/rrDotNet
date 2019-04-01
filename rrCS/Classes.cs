using System;

namespace rrCS
{

    /// <summary>
    /// 类成员
    /// </summary>
    public class ClassesMembers
    {
        /// <summary>
        /// 字段
        /// </summary>
        private static int _field;
        private readonly int[] _array = new int[Size];

        /// <summary>
        /// 常量
        /// </summary>
        public const int Constant = default;
        private const int Size = 100;

        /// <summary>
        /// 属性
        /// </summary>
        public int Property { get; set; }

        /// <summary>
        /// 方法
        /// </summary>
        public int Method() => _field * Constant;

        /// <summary>
        /// 构造函数
        /// </summary>
        static ClassesMembers() => _field = default;
        public ClassesMembers() => ++_field;

        /// <summary>
        /// 终结器
        /// </summary>
        ~ClassesMembers() => --_field;

        /// <summary>
        /// 索引器
        /// </summary>
        public int this[int i]
        {
            get => _array[Math.Min(Math.Max(0, i), Size - 1)];
            set => _array[Math.Min(Math.Max(0, i), Size - 1)] = value;
        }
    }

}

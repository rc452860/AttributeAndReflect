using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectTest.Model
{
    public class PersonCheckAttribute:Attribute
    {

        // 三个bool变量用于确定是有要验证这些信息
        private bool checkEmpty = false; //是否为空
        private bool checkMaxLength = false; //最大长度
        private bool checkRegex = false; //用正则表达式验证参数(是邮箱，是否刷数字)

        private int maxLength = 0;
        private string regexStr = string.Empty;


        public bool CheckEmpty
        {
            get { return this.checkEmpty; }
            set { this.checkEmpty = value; }
        }

        public bool CheckMaxLength
        {
            get { return this.checkMaxLength; }
            set { this.checkMaxLength = value; }
        }

        public bool CheckRegex
        {
            get { return this.checkRegex; }
            set { this.checkRegex = value; }
        }

        public int MaxLength
        {
            get { return this.maxLength; }
            set { this.maxLength = value; }
        }

        public string RegexStr
        {
            get { return this.regexStr; }
            set { this.regexStr = value; }
        }
    }
}

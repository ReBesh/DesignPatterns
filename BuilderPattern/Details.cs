using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public class Details
    {
        public string Detail1, Detail2;
        public List<Details> Detail = new List<Details>();
        private const int indentSize = 5;

        public Details()
        {

        }

        public Details(string name, string text)
        {
            Detail1 = name ?? throw new ArgumentNullException(paramName: nameof(name));
            Detail2 = text ?? throw new ArgumentNullException(paramName: nameof(text));
        }

        private string ToStringImpl(int indent)
        {
            var sb = new StringBuilder();
            var i = new string(' ', indentSize * indent);
            sb.Append($"{i}<{Detail1}>");

            if (!string.IsNullOrWhiteSpace(Detail2))
            {
                sb.Append(new string(' ', indentSize * (indent + 1)));
                sb.AppendLine(Detail2);
            }

            foreach (var e in Detail)
            {
                sb.Append(e.ToStringImpl(indent + 1));
            }
            sb.AppendLine($"{i}</{Detail1}");
            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringImpl(0);
        }
    }

    public class BuildDetails
    {
        private readonly string givendet;
        Details det = new Details();

        public BuildDetails(string rootName)
        {
            this.givendet = rootName;
            det.Detail1 = rootName;
        }

        public void AddChild(string childName, string childText)
        {
            var e = new Details(childName, childText);
            det.Detail.Add(e);
        }

        public override string ToString()
        {
            return det.ToString();
        }

        public void Clear()
        {
            det = new Details { Detail1 = givendet };
        }
    }
}
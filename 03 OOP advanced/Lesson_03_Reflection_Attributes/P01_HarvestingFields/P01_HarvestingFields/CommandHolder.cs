namespace P01_HarvestingFields
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class CommandHolder
    {
        private FieldInfo[] fields;

        public CommandHolder(Type type)
        {
            this.fields = type
                .GetFields(
                  BindingFlags.Public
                | BindingFlags.Instance  
                | BindingFlags.NonPublic
                | BindingFlags.FlattenHierarchy);
        }

        public object[] GetPrivateFields()
        {
            return new object[]
            {
                this.fields.Where(x => x.IsPrivate)
                .Select(x => $"{x.Attributes.ToString().ToLower()} {x.FieldType.ToString().Split('.').Last()} {x.Name}")
                .ToArray()
                , ConsoleColor.Yellow
            };
        }

        public object[] GetProtectedFields()
        {
            var result =  new object[]
            {
                this.fields
                .Where(x => !x.IsPrivate && !x.IsPublic)
                .Select(x => $"protected {x.FieldType.ToString().Split('.').Last()} {x.Name}")
                .ToArray(),
                ConsoleColor.DarkRed
            };

            return result;
        }

        public object[] GetPublicFields()
        {
            return new object[]
            {
                this.fields
                .Where(x => x.IsPublic)
                .Select(x => $"{x.Attributes.ToString().ToLower()} {x.FieldType.ToString().Split('.').Last()} {x.Name}")
                .ToArray()
                , ConsoleColor.DarkGreen
            };
        }

        public object[] GetAllFields()
        {
            return new object[]
            {
                this.fields
                .Select(x => new {
                    attr = x.Attributes.ToString() == "Family" ? "protected" : x.Attributes.ToString().ToLower(),
                    type = x.FieldType.ToString().Split('.').Last(),
                    name = x.Name
                })
                .Select(x => $"{x.attr} {x.type} {x.name}")
                .ToArray()
                , ConsoleColor.White
            };
        }
    }
}

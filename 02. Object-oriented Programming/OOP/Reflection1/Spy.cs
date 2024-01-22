using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection1
{
	public class Spy
	{
		public string StealFieldInfo(string investigatedClass, params string[] requestedFields)
		{
			Type classType = Type.GetType(investigatedClass);
			FieldInfo[] classFields = classType.GetFields(
				System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public);
			StringBuilder stringBuilder = new StringBuilder();
			Object classInstance = Activator.CreateInstance(classType, new object[] { });
			stringBuilder.AppendLine($"Class under investigation: {investigatedClass}");
			foreach(FieldInfo field in classFields.Where(f => requestedFields.Contains(f.Name)))
			{
				stringBuilder.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
			}
			return stringBuilder.ToString().Trim();
		}
	}
}

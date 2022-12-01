﻿using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;

namespace CSharpLearningApp.Classes.CSharpCompiler
{
	public class Script
	{
		ScriptState state;

		public static async Task<Script> Create(IEnumerable<Assembly> references, IEnumerable<string> usings)
		{
			var options = ScriptOptions.Default.WithReferences(references).WithImports(usings);
			var state = await CSharpScript.RunAsync("", options);
			return new Script() { state = state };
		}

		public async Task<object> ExecuteNext(string code)
		{
			state = await state.ContinueWithAsync(code);
			var result = state.ReturnValue;
			return result;
		}
	}
}

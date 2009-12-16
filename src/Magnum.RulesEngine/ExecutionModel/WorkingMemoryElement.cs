// Copyright 2007-2008 The Apache Software Foundation.
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace Magnum.RulesEngine.ExecutionModel
{
	using System;

	public interface WorkingMemoryElement
	{
		Type ElementType { get; }
	}

	public interface WorkingMemoryElement<T> :
		WorkingMemoryElement
	{
		/// <summary>
		/// Access the value of the working memory element
		/// </summary>
		/// <param name="callback">The callback to invoke when the value is available</param>
		void Access(Action<T> callback);

		/// <summary>
		/// Access the value of the working memory element and return a value to replace it (modify)
		/// </summary>
		/// <param name="callback">The callback to invoke when the value is available</param>
		void Access(Func<T, T> callback);
	}
}
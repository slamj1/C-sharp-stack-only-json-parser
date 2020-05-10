﻿using System;
using System.Text.Json;
using StackOnlyJsonParser.Example.Model;

namespace StackOnlyJsonParser.Example
{
	class Program
	{
		static void Main(string[] args)
		{
			var bytes = JsonSerializer.SerializeToUtf8Bytes(new {
				Name = "Some name",
				Price = 1.2,
				Id1 = 1,
				Id2 = 2
			});

			var product = new Product(bytes);

			Console.WriteLine(product.Id1);
			Console.WriteLine(product.Id2);
		}
	}
}

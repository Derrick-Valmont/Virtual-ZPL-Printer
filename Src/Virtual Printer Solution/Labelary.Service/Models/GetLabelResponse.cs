﻿using Labelary.Abstractions;

namespace Labelary.Service
{
	internal class GetLabelResponse : IGetLabelResponse
	{
		public bool Result { get; set; }
		public byte[] Label { get; set; }
		public string Error { get; set; }
	}
}

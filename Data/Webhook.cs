﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_AI_Assistant.Data
{
	public class Webhook
	{
		public String Token { get; set; } = "";
		public String URl { get; set; } = "";
		public GetPost Getpost { get; set; } = GetPost.GET;
		public String Parameter { get; set; } = "";
		public enum GetPost
		{
			GET,
			POST
		}
	}
}

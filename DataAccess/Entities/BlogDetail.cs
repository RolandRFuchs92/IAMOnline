﻿using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities
{
	public class BlogDetail
	{
		[Key]
		public int BlogDetailId { get; set; }
		public string BlogImagePath { get; set; }
		public string BlogTitle { get; set; }
		public string BlogAuthor { get; set; }
		public DateTime BlogWrittenOn { get; set; }
		public string BlogIntro { get; set; }
		public string BlogBody { get; set; }
		public string BlogRemarks { get; set; }
		public string BlogClosingCaption { get; set; }
		public DateTime BlogStartingDate { get; set; }
		public DateTime CreatedOn { get; set; }
		public BlogType BlogType { get; set; }
		public bool IsDeleted { get; set; }
		public bool IsActive { get; set; }
	}
	/*
	https://next.json-generator.com/
[
  {
    'repeat(5, 10)': {
      "BlogImagePath": "/content/placeholderImage.jpg",
      "BlogTitle": '{{lorem(4, "words")}}',
      "BlogAuthor": "{{firstName()}} {{surname()}}",
      "BlogWrittenOn": "{{moment(this.date(new Date(2014, 0, 1), new Date())).format('DD MMM YYYY')}}",
      "BlogIntro": "{{lorem(15, 'words')}}",
      "BlogBody": "{{lorem(1, 'paragraphs')}}",
      "BlogRemarks" : "{{lorem(10, 'words')}}",
      "BlogClosingCaption": "{{lorem(5, 'words')}}",
      "BlogStartingDate": "{{moment(this.date(new Date(2014, 0, 1), new Date())).format('DD MMM YYYY')}}",
      "CreatedOn": "{{moment(this.date(new Date(2014, 0, 1), new Date())).format('DD MMM YYYY')}}",
      "BlogType": "1",
      "IsDeleted": "{{bool()}}",
      "IsActive": "{{bool()}}"
      }
    }
  
]
	 */
}
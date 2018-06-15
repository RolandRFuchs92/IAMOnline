using System;
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
}
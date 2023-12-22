namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ChatLanguageIteratorSchema

	/// <exclude/>
	public class ChatLanguageIteratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ChatLanguageIteratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ChatLanguageIteratorSchema(ChatLanguageIteratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bfb32ab4-18f2-0b7b-7c32-952642edc498");
			Name = "ChatLanguageIterator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("01343ce8-0448-497f-b2c3-9511b4580fa3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,81,203,106,195,64,12,60,59,144,127,16,206,37,129,226,189,231,117,104,122,9,20,90,74,115,42,61,40,91,217,89,88,175,195,62,40,105,201,191,87,107,199,169,157,228,208,26,22,163,209,104,52,146,12,150,228,246,40,9,94,201,90,116,85,238,179,85,101,114,85,4,139,94,85,102,56,248,30,14,146,224,148,41,122,20,75,179,225,128,51,35,75,5,211,96,165,209,185,41,172,118,232,31,209,20,1,11,90,123,98,141,202,214,60,33,4,204,93,40,75,180,135,229,41,110,9,144,243,211,202,249,216,100,123,128,167,210,168,40,4,250,164,228,178,86,65,116,36,246,97,171,149,4,25,59,223,108,12,83,184,71,71,215,126,146,56,211,175,245,202,56,111,131,228,20,79,240,92,171,214,158,175,76,55,174,141,242,10,181,250,34,7,134,62,65,113,53,26,222,96,149,51,153,8,164,165,124,145,222,50,148,138,101,6,103,97,113,169,60,223,163,197,18,12,223,100,145,6,71,150,157,25,146,241,12,233,114,195,49,200,51,144,205,69,205,174,139,79,155,184,213,114,188,233,233,64,95,118,18,171,147,41,108,121,77,227,139,84,210,108,41,105,21,95,130,230,137,23,245,204,235,46,248,246,14,13,51,137,41,86,240,40,253,218,180,87,236,82,47,220,76,238,58,117,59,100,88,255,187,238,129,114,12,250,15,236,227,44,254,142,205,101,71,100,62,154,243,215,113,131,246,65,198,186,223,15,75,72,139,227,42,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bfb32ab4-18f2-0b7b-7c32-952642edc498"));
		}

		#endregion

	}

	#endregion

}


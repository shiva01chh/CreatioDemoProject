namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: StringExtentionsSchema

	/// <exclude/>
	public class StringExtentionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public StringExtentionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public StringExtentionsSchema(StringExtentionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("57b5ada9-5411-44e8-a972-15aef76f4662");
			Name = "StringExtentions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,145,65,75,195,64,16,133,207,9,244,63,140,173,208,68,74,168,61,120,176,20,10,165,7,193,158,34,120,144,30,214,116,154,44,38,155,178,51,17,37,228,191,187,217,77,90,91,69,220,219,206,188,247,237,155,89,80,162,64,58,136,4,225,9,181,22,84,238,57,90,149,106,47,211,74,11,150,165,138,214,207,241,192,175,7,190,87,145,84,41,196,159,196,88,204,7,190,169,140,52,166,70,2,171,92,16,221,67,204,218,40,214,31,140,170,117,146,213,72,197,168,149,200,129,216,240,18,72,90,237,15,41,24,101,109,245,71,232,6,57,43,119,6,251,208,17,92,251,146,71,150,4,27,65,111,184,91,23,66,230,1,103,146,250,58,149,149,78,48,132,118,0,207,123,23,26,14,66,51,193,162,235,68,241,33,151,28,140,151,227,112,110,37,114,15,129,149,68,143,168,82,206,224,106,1,179,222,239,105,228,74,171,206,235,12,205,145,220,238,210,128,173,251,101,186,117,237,206,113,61,172,219,118,20,87,175,46,89,48,157,152,208,156,69,27,169,130,217,196,154,187,39,195,176,185,177,103,89,59,214,237,182,25,90,90,243,143,29,252,49,254,41,75,63,252,175,105,238,38,253,114,46,242,156,133,24,161,218,185,175,178,119,87,61,47,218,218,247,243,5,141,73,235,115,111,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("57b5ada9-5411-44e8-a972-15aef76f4662"));
		}

		#endregion

	}

	#endregion

}


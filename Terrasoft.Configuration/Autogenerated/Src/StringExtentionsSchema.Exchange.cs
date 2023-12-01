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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,145,65,75,195,64,16,133,207,41,244,63,140,173,208,68,66,168,61,120,176,20,10,37,7,193,158,34,120,144,30,214,100,154,44,166,155,178,51,17,37,228,191,187,217,77,42,173,34,238,109,103,222,251,246,205,44,40,113,64,58,138,20,225,9,181,22,84,237,57,218,84,106,47,243,90,11,150,149,138,226,231,100,60,106,198,35,175,38,169,114,72,62,137,241,176,28,143,76,101,170,49,55,18,216,148,130,232,30,18,214,70,17,127,48,170,206,73,86,35,21,163,86,162,4,98,195,75,33,237,180,63,164,96,148,141,213,159,160,91,228,162,202,12,246,161,39,184,246,37,143,44,9,182,130,222,48,139,15,66,150,62,23,146,134,58,85,181,78,49,128,110,0,207,123,23,26,142,66,51,193,170,239,68,201,177,148,236,207,214,179,96,105,37,114,15,190,149,68,143,168,114,46,224,106,5,139,193,239,105,228,90,171,222,235,12,237,137,220,237,210,128,173,251,101,190,115,237,222,113,61,105,186,118,148,212,175,46,153,63,15,77,104,46,162,173,84,254,34,180,230,254,201,32,104,111,236,89,55,142,117,187,107,39,150,214,254,99,7,127,140,255,157,101,24,254,215,52,119,225,176,156,139,60,103,33,166,168,50,247,85,246,238,170,231,69,91,51,231,11,208,122,253,196,102,2,0,0 };
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


namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseLanguageIteratorSchema

	/// <exclude/>
	public class CaseLanguageIteratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseLanguageIteratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseLanguageIteratorSchema(CaseLanguageIteratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2765b5d5-b370-4bb8-88bf-c51f5ee29ecf");
			Name = "CaseLanguageIterator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,83,203,106,195,48,16,60,59,144,127,88,220,75,2,193,190,231,117,72,122,9,180,80,210,230,84,122,80,212,181,17,200,146,209,131,54,45,249,247,174,20,39,177,211,208,135,193,152,221,157,153,29,173,214,138,85,104,107,198,17,158,208,24,102,117,225,178,165,86,133,40,189,97,78,104,213,239,125,246,123,137,183,66,149,29,136,193,73,191,71,149,27,131,37,193,96,41,153,181,99,88,50,139,119,76,149,158,149,184,114,72,26,218,68,92,158,231,48,181,190,170,152,217,205,155,248,8,128,130,94,41,172,11,77,182,59,224,36,2,178,81,177,217,145,157,183,232,181,223,74,193,129,135,174,87,155,194,24,22,87,189,36,225,60,103,219,90,89,103,60,167,18,185,127,136,170,209,239,55,195,7,199,74,56,193,164,248,64,11,10,223,64,16,155,41,154,158,46,8,140,8,220,96,49,75,175,25,74,243,121,6,39,225,252,82,121,90,51,195,42,80,116,31,179,212,91,52,228,76,33,15,87,144,206,55,20,3,63,37,178,105,30,209,145,220,76,226,90,203,193,166,163,3,93,217,97,96,39,99,216,18,115,112,81,130,56,164,228,40,184,246,146,14,60,139,71,94,181,147,207,47,13,50,9,165,123,38,228,66,191,7,43,107,26,47,13,54,174,80,155,112,97,105,56,58,179,111,177,96,94,58,42,58,198,221,15,164,17,196,1,167,109,114,211,250,239,173,30,125,93,107,227,254,197,9,246,126,71,239,39,225,179,15,91,20,55,13,213,235,97,217,98,188,63,252,53,157,36,229,232,249,2,105,55,158,177,139,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2765b5d5-b370-4bb8-88bf-c51f5ee29ecf"));
		}

		#endregion

	}

	#endregion

}


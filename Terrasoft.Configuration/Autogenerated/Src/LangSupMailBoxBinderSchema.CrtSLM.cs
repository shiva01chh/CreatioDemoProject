namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LangSupMailBoxBinderSchema

	/// <exclude/>
	public class LangSupMailBoxBinderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LangSupMailBoxBinderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LangSupMailBoxBinderSchema(LangSupMailBoxBinderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("eab7a1a7-4947-4699-89fb-5232e0e5fe99");
			Name = "LangSupMailBoxBinder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,80,193,106,195,48,12,61,167,208,127,16,217,165,131,145,220,219,46,176,148,13,6,45,43,116,176,179,155,40,153,33,177,131,236,132,150,178,127,159,98,39,91,10,173,47,70,239,61,61,73,79,137,26,77,35,50,132,79,36,18,70,23,54,218,104,85,200,178,37,97,165,86,243,217,101,62,11,90,35,85,121,37,33,140,222,68,102,53,73,52,171,27,138,47,60,178,170,174,181,98,150,249,7,194,146,237,96,83,9,99,150,176,21,170,60,180,205,78,200,42,213,167,84,170,28,201,233,226,56,134,181,105,235,90,208,57,25,106,79,67,161,137,41,68,200,8,139,231,240,253,191,191,119,219,147,238,36,203,194,56,137,70,159,120,98,212,180,199,74,102,144,245,243,111,142,135,37,188,52,205,107,135,202,110,165,177,168,144,82,97,144,91,47,110,179,191,19,118,104,191,117,206,71,236,157,165,39,7,123,221,113,2,188,6,116,90,230,240,161,216,241,96,5,217,197,104,205,225,90,60,89,200,252,255,8,125,188,65,112,228,73,209,68,62,210,43,199,186,208,124,220,103,7,4,81,191,243,250,78,4,79,112,27,79,22,225,53,17,122,255,159,225,62,84,185,63,209,213,30,189,6,25,155,190,95,135,74,194,178,62,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eab7a1a7-4947-4699-89fb-5232e0e5fe99"));
		}

		#endregion

	}

	#endregion

}


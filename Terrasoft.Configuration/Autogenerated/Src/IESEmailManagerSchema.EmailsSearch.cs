namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IESEmailManagerSchema

	/// <exclude/>
	public class IESEmailManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IESEmailManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IESEmailManagerSchema(IESEmailManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0f0a3bfc-dd1a-49ca-91a0-daff393823fe");
			Name = "IESEmailManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("92df5372-6a61-42f2-95f4-67c9e246a93f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,82,203,110,194,48,16,60,131,196,63,172,232,165,149,80,210,51,132,92,40,170,144,138,138,74,127,192,132,77,176,20,219,212,107,83,33,212,127,175,95,161,148,182,106,46,145,199,51,179,59,187,150,76,32,237,89,133,240,138,90,51,82,181,201,102,74,214,188,177,154,25,174,100,54,23,140,183,180,70,166,171,221,160,127,26,244,123,150,184,108,96,125,36,131,194,145,219,22,43,207,164,236,17,37,106,94,77,6,125,199,186,209,216,56,20,22,210,160,174,93,133,49,44,230,235,224,182,100,146,53,168,3,45,207,115,40,200,10,193,244,177,76,231,149,86,7,190,69,2,129,102,167,182,4,181,210,128,94,9,20,250,112,245,179,78,155,95,136,247,118,211,242,10,120,87,242,103,197,222,41,84,61,119,183,140,21,198,176,10,210,120,121,221,83,0,226,4,98,27,148,157,105,249,53,175,216,51,205,4,72,55,216,233,80,227,155,69,50,195,242,137,147,1,85,167,254,129,140,118,25,40,43,242,192,254,67,172,222,103,202,74,167,14,63,47,119,16,185,120,160,209,88,45,225,192,90,139,255,154,208,115,93,19,58,155,23,175,86,225,224,77,26,191,46,214,58,51,218,187,245,253,98,20,203,80,249,192,195,134,93,76,223,68,26,65,145,119,215,158,191,152,75,43,156,221,166,197,226,139,94,196,160,163,20,184,44,211,24,227,163,186,245,83,73,148,18,210,172,70,126,125,208,101,135,41,220,159,145,20,196,99,119,147,180,71,148,219,184,202,112,254,136,79,239,27,232,176,203,239,19,72,63,98,47,242,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0f0a3bfc-dd1a-49ca-91a0-daff393823fe"));
		}

		#endregion

	}

	#endregion

}


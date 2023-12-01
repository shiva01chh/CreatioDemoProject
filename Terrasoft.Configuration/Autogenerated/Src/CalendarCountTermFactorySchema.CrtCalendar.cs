namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CalendarCountTermFactorySchema

	/// <exclude/>
	public class CalendarCountTermFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CalendarCountTermFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CalendarCountTermFactorySchema(CalendarCountTermFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0a4f01d7-03db-4c5d-934f-5339cf3d53d8");
			Name = "CalendarCountTermFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,84,203,110,219,48,16,60,43,64,254,97,225,94,156,11,117,79,28,3,173,210,199,197,64,129,58,232,121,77,173,100,34,18,41,240,97,87,8,242,239,93,189,104,199,73,107,71,7,9,92,206,204,14,87,220,213,88,147,107,80,18,172,201,90,116,166,240,34,51,186,80,101,176,232,149,209,34,195,138,116,142,214,93,95,61,95,95,37,193,41,93,194,175,214,121,170,239,226,250,152,108,73,124,67,233,141,85,228,14,136,40,179,86,53,61,106,229,225,254,124,74,49,129,89,135,149,62,89,42,121,31,178,10,157,131,219,168,153,153,160,61,139,213,67,222,182,7,167,105,10,11,23,234,26,109,187,28,215,19,1,100,199,0,207,20,40,6,142,152,40,233,17,167,9,155,74,73,144,125,190,127,103,75,158,251,140,209,223,138,252,214,228,157,195,159,189,192,176,123,106,168,15,124,39,15,18,43,25,170,254,232,80,147,220,162,86,174,134,77,11,165,218,145,6,207,53,128,192,69,16,81,37,61,149,89,52,104,177,6,205,127,243,126,230,199,162,205,150,235,72,93,164,61,226,64,176,228,131,213,110,153,189,151,156,225,211,126,71,24,203,176,83,214,7,172,224,11,58,138,69,232,78,16,23,243,183,127,121,50,115,3,221,237,73,18,183,87,94,110,97,126,26,79,36,171,190,189,37,98,165,116,240,116,59,96,146,193,213,112,1,198,242,11,54,176,24,80,209,199,114,126,115,247,95,213,223,198,62,241,173,188,76,252,21,248,242,28,63,76,176,231,164,59,204,135,93,95,34,124,4,189,92,255,1,219,115,186,12,249,176,223,11,100,15,200,119,212,115,42,48,84,126,210,216,113,255,242,224,48,118,69,206,97,73,60,72,102,143,26,55,21,129,55,32,45,161,39,64,110,113,107,121,180,25,157,119,227,231,208,240,2,98,87,128,114,252,117,13,73,85,40,202,197,108,76,152,248,173,53,123,208,180,135,207,182,12,53,105,255,245,143,164,166,107,146,249,113,234,209,225,75,247,126,25,103,0,215,96,24,3,253,122,136,190,14,114,140,159,191,39,113,25,248,122,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0a4f01d7-03db-4c5d-934f-5339cf3d53d8"));
		}

		#endregion

	}

	#endregion

}


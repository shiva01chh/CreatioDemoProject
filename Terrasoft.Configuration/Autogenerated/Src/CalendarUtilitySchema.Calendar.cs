namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CalendarUtilitySchema

	/// <exclude/>
	public class CalendarUtilitySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CalendarUtilitySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CalendarUtilitySchema(CalendarUtilitySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("79e58c22-6756-4f35-93bc-da6c46a7c24a");
			Name = "CalendarUtility";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,82,203,78,195,48,16,60,183,82,255,97,149,94,202,37,190,67,26,9,202,165,55,36,218,15,216,186,155,98,41,177,35,63,64,165,226,223,89,59,105,104,194,133,35,57,197,227,157,241,204,216,26,27,114,45,74,130,29,89,139,206,84,62,223,24,93,169,83,176,232,149,209,249,6,107,210,71,180,110,49,191,44,230,179,224,148,62,141,134,45,61,44,230,188,179,180,116,98,2,108,106,116,14,238,225,74,220,123,85,43,127,78,51,66,8,40,92,104,26,180,231,178,95,63,130,76,12,255,134,30,90,107,222,213,145,28,200,158,13,94,53,20,87,50,212,201,16,132,164,167,200,229,87,65,113,163,216,134,67,173,36,180,104,189,194,186,151,158,88,249,109,238,9,29,49,249,146,76,254,36,49,218,121,27,164,55,54,6,122,73,210,221,200,52,72,2,182,90,197,67,213,39,251,71,208,244,1,138,5,80,115,187,166,226,124,196,20,226,48,150,170,117,54,113,144,137,178,51,155,15,242,98,170,95,112,42,108,64,243,157,173,179,224,200,178,65,77,50,182,146,149,59,150,143,24,200,1,204,11,145,24,73,160,47,102,114,236,106,63,146,129,177,234,29,167,62,112,53,171,41,28,95,194,236,235,191,84,225,248,130,168,107,32,253,254,37,247,246,10,60,163,199,215,200,42,6,168,184,217,60,151,101,39,58,116,209,175,110,43,88,242,112,247,102,210,186,67,199,32,99,241,251,6,186,102,212,15,112,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("79e58c22-6756-4f35-93bc-da6c46a7c24a"));
		}

		#endregion

	}

	#endregion

}


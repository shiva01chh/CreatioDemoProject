namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IReportGeneratorSchema

	/// <exclude/>
	public class IReportGeneratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IReportGeneratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IReportGeneratorSchema(IReportGeneratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1f7efd48-adaa-42e5-b285-f3efa252f7e7");
			Name = "IReportGenerator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,82,65,106,195,48,16,60,39,144,63,44,238,165,133,98,221,19,215,151,22,74,14,133,144,54,15,80,229,181,35,136,37,179,146,2,33,244,239,149,37,91,196,110,234,139,209,104,102,119,118,86,138,183,104,58,46,16,190,144,136,27,93,219,252,85,171,90,54,142,184,149,90,173,150,215,213,114,225,140,84,205,127,148,124,143,157,38,251,137,116,150,2,55,119,233,212,227,254,230,129,176,241,18,216,42,139,84,251,190,107,216,70,249,59,42,244,245,52,5,30,99,12,10,227,218,150,211,165,28,206,59,210,103,89,161,1,10,2,104,162,162,111,85,59,37,122,43,252,36,237,37,31,245,236,166,64,231,190,79,82,128,28,251,222,105,187,184,134,214,201,227,7,218,163,174,204,26,118,65,27,47,231,198,2,48,20,73,214,242,196,100,115,106,209,113,226,45,40,159,251,75,230,12,146,143,82,97,48,159,149,7,127,6,145,128,188,96,129,125,95,44,110,119,144,149,41,157,9,14,181,166,89,94,154,254,214,37,180,142,148,41,247,241,15,157,151,112,194,106,156,167,96,35,163,151,196,228,222,184,229,105,242,199,195,100,20,152,78,246,12,179,176,39,239,103,234,248,105,51,108,1,85,21,23,17,206,63,241,249,76,192,128,245,223,47,174,193,92,10,198,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1f7efd48-adaa-42e5-b285-f3efa252f7e7"));
		}

		#endregion

	}

	#endregion

}


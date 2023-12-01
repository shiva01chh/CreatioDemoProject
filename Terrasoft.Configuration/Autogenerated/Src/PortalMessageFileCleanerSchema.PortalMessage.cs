namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PortalMessageFileCleanerSchema

	/// <exclude/>
	public class PortalMessageFileCleanerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PortalMessageFileCleanerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PortalMessageFileCleanerSchema(PortalMessageFileCleanerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("58b34129-eda1-43f6-b441-329cc91b3415");
			Name = "PortalMessageFileCleaner";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c85d2d65-6230-4aeb-9934-bfac9785d42f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,84,77,111,219,48,12,61,187,64,255,3,225,93,28,160,179,119,110,19,23,173,219,12,57,20,40,176,22,59,14,138,77,167,2,100,201,163,164,102,89,177,255,62,218,78,178,216,249,88,124,19,249,244,248,248,72,89,139,10,109,45,114,132,23,36,18,214,148,46,206,140,46,229,194,147,112,210,232,203,139,143,203,139,192,91,169,23,240,109,101,29,86,55,219,243,238,21,194,99,241,248,225,158,83,156,252,68,184,96,70,200,148,176,246,26,158,13,57,161,158,208,90,177,192,169,84,152,41,20,26,169,197,214,126,174,100,14,121,3,61,129,12,62,90,244,150,122,42,81,21,13,55,201,119,225,176,75,214,221,1,8,69,97,180,90,193,171,69,226,38,53,230,77,135,240,195,247,206,55,107,74,212,69,199,218,47,193,64,235,200,231,206,80,83,168,213,217,33,146,36,129,177,245,85,37,104,149,110,2,51,45,157,20,74,254,70,11,26,151,32,249,182,208,236,183,41,25,140,8,57,97,57,9,143,181,24,38,105,188,229,78,134,228,227,90,144,168,64,243,16,39,97,191,139,48,109,186,132,124,27,136,199,73,139,110,47,175,237,61,86,53,26,56,212,167,30,65,179,18,65,48,240,13,38,176,103,100,16,252,57,237,230,19,186,55,83,156,99,228,3,42,116,108,98,221,106,134,170,19,13,37,171,134,249,10,22,242,29,53,200,2,181,147,165,228,206,217,223,3,208,115,205,172,135,206,204,138,48,157,253,151,125,215,227,150,147,208,121,210,54,125,33,143,87,32,203,78,239,82,88,40,218,126,138,43,48,238,13,105,41,45,194,103,40,133,178,13,203,230,218,206,172,230,198,168,181,9,123,99,139,190,122,89,192,1,205,155,81,117,124,237,2,118,20,209,96,120,163,22,22,196,83,50,85,180,191,141,225,58,31,196,223,89,44,70,33,219,177,9,5,241,204,62,254,244,66,69,153,81,190,210,241,115,99,1,215,160,232,144,162,45,211,157,46,162,48,227,71,201,46,220,175,206,35,28,168,142,51,79,196,51,105,214,181,249,109,57,145,187,127,37,226,199,95,152,123,238,117,4,41,124,129,91,224,103,139,112,221,153,124,98,57,187,104,63,200,49,254,254,2,15,49,15,125,46,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("58b34129-eda1-43f6-b441-329cc91b3415"));
		}

		#endregion

	}

	#endregion

}


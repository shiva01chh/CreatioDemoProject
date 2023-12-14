namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationInfoSchema

	/// <exclude/>
	public class INotificationInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationInfoSchema(INotificationInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("aee85563-7cba-4466-bec1-e9df72ba319c");
			Name = "INotificationInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,148,93,110,194,48,16,132,159,65,226,14,123,2,114,0,170,74,253,19,138,212,242,0,244,0,38,222,132,69,120,141,236,205,67,132,122,247,218,6,84,42,72,139,137,18,43,63,158,249,50,35,39,172,12,250,157,170,16,150,232,156,242,182,150,241,139,229,154,154,214,41,33,203,163,225,126,52,28,180,158,184,129,69,231,5,205,36,92,135,189,40,10,120,240,173,49,202,117,143,199,235,146,5,93,29,221,106,235,128,56,140,38,185,128,173,65,214,8,108,133,106,170,210,189,241,201,164,56,115,217,181,171,45,85,65,122,50,42,103,103,146,50,56,134,73,241,141,46,248,233,198,146,100,139,125,176,75,218,192,139,139,193,14,178,61,52,40,19,240,113,248,138,79,123,49,207,86,119,249,148,164,186,29,82,106,228,31,235,19,142,140,106,176,135,51,109,73,67,25,39,148,58,3,52,199,202,58,13,116,228,161,3,187,218,96,37,25,9,19,249,45,200,165,203,66,47,170,53,26,5,28,86,97,126,159,7,222,193,98,22,29,242,187,13,89,111,77,247,129,222,95,109,182,23,242,170,4,65,177,6,161,172,120,81,183,140,146,57,26,98,157,78,111,101,158,127,45,176,181,74,199,132,161,155,191,155,124,79,19,239,236,240,247,250,212,232,133,248,223,54,195,175,228,73,135,116,159,76,146,193,156,58,219,238,238,92,46,73,123,53,99,56,82,167,113,251,6,210,5,53,188,17,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aee85563-7cba-4466-bec1-e9df72ba319c"));
		}

		#endregion

	}

	#endregion

}


namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISynchronizationUCManagerSchema

	/// <exclude/>
	public class ISynchronizationUCManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISynchronizationUCManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISynchronizationUCManagerSchema(ISynchronizationUCManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e35281b7-8278-4872-974a-551e3823b083");
			Name = "ISynchronizationUCManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,84,193,110,219,48,12,61,167,64,255,129,72,47,27,80,216,247,197,53,48,4,65,144,67,135,97,93,119,87,29,218,17,32,209,41,69,13,200,130,253,251,36,185,201,108,183,14,122,216,114,51,249,248,248,248,72,133,148,69,183,87,21,194,119,100,86,174,173,37,91,182,84,235,198,179,18,221,210,245,213,241,250,106,230,157,166,6,30,14,78,208,46,70,223,1,111,12,86,17,236,178,53,18,178,174,254,98,250,180,140,83,241,108,69,162,69,163,123,11,240,112,160,72,24,50,55,140,77,104,3,27,18,228,58,168,254,4,155,152,221,113,75,250,87,210,251,184,188,87,164,26,228,84,176,247,79,70,87,160,79,248,75,240,217,49,149,204,242,60,135,194,121,107,21,31,202,83,224,27,26,37,184,13,9,68,168,24,235,187,249,152,42,216,38,28,173,224,121,94,130,182,123,131,22,73,82,14,40,248,156,157,217,243,62,189,19,238,204,156,96,251,18,74,225,8,13,202,2,126,95,148,40,158,201,129,119,200,14,100,167,4,118,202,65,177,87,172,108,80,156,52,220,205,49,58,125,136,18,221,176,35,84,161,165,170,4,244,214,129,209,78,38,244,166,72,34,29,50,150,61,111,86,231,38,154,156,40,170,48,43,242,84,243,54,133,74,231,51,47,71,38,64,23,135,186,229,233,57,46,51,71,55,130,151,132,47,29,122,34,31,135,169,139,98,185,51,183,140,53,39,163,130,213,164,159,61,6,195,162,152,90,71,223,147,113,69,126,194,71,130,205,138,188,69,86,79,6,139,181,215,219,18,214,40,227,59,140,75,251,208,217,6,221,104,183,233,36,62,87,61,35,110,97,168,25,134,211,125,92,188,227,60,248,229,146,187,38,97,22,227,45,193,79,101,252,212,129,254,143,133,255,227,181,188,82,178,76,99,253,136,83,141,24,250,155,121,133,141,155,249,170,56,12,152,30,124,122,135,231,228,120,61,239,217,69,247,96,111,144,182,221,95,87,252,12,177,254,239,15,206,154,90,201,131,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e35281b7-8278-4872-974a-551e3823b083"));
		}

		#endregion

	}

	#endregion

}


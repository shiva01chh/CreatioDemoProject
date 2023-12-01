namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysSettingsValueEventListenerSchema

	/// <exclude/>
	public class SysSettingsValueEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysSettingsValueEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysSettingsValueEventListenerSchema(SysSettingsValueEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b87f92fc-2bfc-4aea-b3b7-8872e42ad5ac");
			Name = "SysSettingsValueEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,146,77,79,131,64,16,134,207,144,244,63,76,218,75,155,52,112,175,213,68,73,111,106,76,90,189,24,15,43,76,233,38,176,75,118,118,49,216,248,223,93,22,105,0,169,31,39,50,95,15,239,59,179,130,229,72,5,139,17,118,168,20,35,185,215,65,36,197,158,167,70,49,205,165,152,248,199,137,239,25,226,34,237,181,40,188,56,147,15,54,66,115,205,145,126,109,8,54,37,10,221,233,171,171,219,138,182,168,181,13,9,46,135,147,61,105,65,167,245,44,227,137,101,6,255,1,114,253,150,102,121,51,133,169,173,66,148,49,162,21,12,155,156,248,91,78,26,5,42,55,16,134,33,172,201,228,57,83,213,213,87,236,134,161,80,178,228,9,18,160,115,12,7,38,146,172,86,187,151,10,168,178,140,28,168,117,93,214,116,10,90,96,216,33,62,187,213,85,189,95,207,183,241,1,115,118,111,47,105,125,78,135,50,167,139,23,59,88,152,215,140,199,16,59,53,63,58,129,21,220,48,234,174,176,87,94,143,237,183,150,118,116,43,56,45,237,14,245,65,38,118,109,15,74,106,140,53,38,77,189,104,67,144,165,61,137,93,202,248,197,34,133,76,99,93,106,44,207,31,9,149,189,154,176,195,53,223,244,194,5,212,175,212,243,20,106,163,4,8,124,27,165,206,7,83,245,171,241,62,206,10,43,37,79,224,58,214,134,101,252,253,207,90,150,78,137,55,234,42,62,49,150,208,124,35,251,20,82,220,85,5,2,14,18,173,169,1,41,56,41,114,76,26,152,90,246,126,242,141,217,181,60,67,145,52,231,114,113,147,237,39,109,14,38,190,239,127,2,179,11,57,71,40,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b87f92fc-2bfc-4aea-b3b7-8872e42ad5ac"));
		}

		#endregion

	}

	#endregion

}


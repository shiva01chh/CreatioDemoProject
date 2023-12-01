namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysSettingsRightsEventListenerSchema

	/// <exclude/>
	public class SysSettingsRightsEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysSettingsRightsEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysSettingsRightsEventListenerSchema(SysSettingsRightsEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("42f59b37-f248-46d7-8658-207f7a813139");
			Name = "SysSettingsRightsEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,77,79,131,64,16,61,67,226,127,152,180,151,54,105,224,94,171,137,146,222,212,24,91,79,198,195,10,83,216,4,118,201,238,130,193,198,255,238,176,72,3,20,252,56,109,230,227,189,121,111,102,5,203,80,231,44,68,216,163,82,76,203,131,241,2,41,14,60,46,20,51,92,138,11,247,120,225,58,133,230,34,238,181,40,188,156,200,123,91,97,184,225,168,127,109,240,182,37,10,211,233,171,171,187,74,239,208,24,10,53,92,13,145,61,105,94,167,117,146,227,137,199,137,249,15,83,3,32,62,98,156,43,140,169,12,65,202,180,94,195,89,151,213,127,199,181,65,129,202,34,124,223,135,141,46,178,140,169,234,250,59,182,104,200,149,44,121,132,26,208,154,134,132,137,40,173,5,31,164,2,93,17,71,6,186,53,174,44,189,215,18,250,29,198,23,187,189,170,55,122,177,11,19,204,216,3,29,147,156,206,206,116,206,150,175,132,204,139,183,148,135,16,90,57,63,123,129,53,220,50,221,221,99,175,188,25,93,114,173,238,104,183,112,90,220,61,154,68,70,180,186,71,37,13,134,6,163,166,158,183,33,200,146,238,66,123,153,184,91,160,144,25,172,107,141,237,197,179,70,69,183,19,132,174,7,20,189,112,9,245,103,117,28,133,166,80,2,4,190,143,211,46,6,176,250,247,56,159,147,210,74,201,35,184,9,77,193,82,254,241,103,49,43,176,90,156,113,99,225,137,101,5,205,27,208,143,136,113,95,229,8,56,72,180,190,6,84,222,73,211,168,173,85,111,200,25,103,215,244,28,69,212,156,204,198,77,182,159,164,28,25,114,221,47,74,2,165,101,50,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("42f59b37-f248-46d7-8658-207f7a813139"));
		}

		#endregion

	}

	#endregion

}


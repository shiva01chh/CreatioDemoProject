namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SsoAppEventListenerSchema

	/// <exclude/>
	public class SsoAppEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SsoAppEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SsoAppEventListenerSchema(SsoAppEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("aebf3d9a-9819-4190-84a0-91aa0f7bd750");
			Name = "SsoAppEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,82,193,78,227,48,16,61,23,137,127,24,117,47,69,66,201,29,66,37,168,96,165,213,46,172,20,16,103,215,153,20,139,196,142,102,198,101,81,213,127,223,177,147,34,168,200,193,146,223,248,189,121,51,47,222,244,200,131,177,8,143,72,100,56,180,82,172,130,111,221,38,146,17,23,252,233,201,238,244,100,22,217,249,205,151,39,132,151,223,224,207,184,214,90,223,7,175,85,173,255,32,220,168,8,172,58,195,124,1,53,135,235,97,184,221,162,151,223,142,5,61,82,126,86,150,37,84,28,251,222,208,251,114,186,103,10,12,20,182,174,65,6,165,208,59,12,193,121,129,54,16,212,245,3,24,155,28,50,104,131,200,72,192,200,156,186,177,24,146,226,160,91,126,18,30,226,186,115,22,108,214,254,198,13,92,192,49,116,99,24,149,185,203,70,63,6,250,131,242,18,26,29,233,111,86,28,139,199,99,100,160,78,102,24,226,208,24,65,96,14,96,131,23,181,14,98,248,181,248,224,149,199,196,106,48,100,122,240,154,208,213,60,113,240,159,204,151,21,35,130,37,108,175,230,7,167,171,169,86,46,193,121,157,221,91,44,170,50,179,179,216,52,116,216,106,76,186,75,216,6,215,192,131,175,199,109,101,127,139,35,45,152,250,157,65,74,127,54,115,45,44,126,118,97,109,58,125,88,163,136,198,206,197,29,26,137,132,186,199,95,78,158,157,110,36,74,109,95,176,137,29,210,129,58,75,255,74,241,168,179,114,62,139,220,240,30,223,18,225,73,99,211,150,30,115,146,213,83,94,146,234,173,198,21,221,24,251,186,161,16,125,147,152,231,176,14,161,91,46,132,34,158,93,102,241,125,58,247,83,52,232,155,49,157,124,31,209,175,160,98,159,191,255,88,202,112,200,253,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aebf3d9a-9819-4190-84a0-91aa0f7bd750"));
		}

		#endregion

	}

	#endregion

}


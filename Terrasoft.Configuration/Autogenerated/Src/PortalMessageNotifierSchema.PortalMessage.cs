namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PortalMessageNotifierSchema

	/// <exclude/>
	public class PortalMessageNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PortalMessageNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PortalMessageNotifierSchema(PortalMessageNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1d380dfa-98cc-4b28-8b3b-626ea934efae");
			Name = "PortalMessageNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3cbee395-bc39-4c92-abe2-fb401673f115");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,221,106,194,64,16,133,175,35,248,14,139,189,81,144,60,128,182,133,26,139,21,218,42,213,246,126,186,153,196,133,100,87,246,135,18,196,119,239,100,55,106,108,69,244,102,221,217,111,206,204,156,140,51,66,230,108,85,25,139,229,184,219,113,173,107,156,168,162,64,110,133,146,38,158,161,68,45,248,17,89,163,214,96,84,102,137,210,24,63,75,43,172,64,67,239,221,142,132,18,205,22,56,158,81,50,19,185,211,80,203,117,59,187,154,139,238,52,230,116,101,73,1,198,140,216,82,105,11,197,27,26,3,57,190,43,43,50,129,218,131,188,6,46,191,179,17,155,128,193,127,89,81,40,113,170,65,83,88,237,184,85,154,42,185,239,66,240,0,108,253,255,203,226,125,63,87,197,208,31,3,182,171,19,162,6,154,203,76,177,7,38,241,135,181,35,129,57,64,4,132,100,114,208,174,171,45,166,228,170,43,229,23,20,14,239,169,35,50,243,177,223,107,232,222,96,24,178,19,141,96,49,157,84,243,244,186,194,204,137,148,242,91,252,95,141,133,188,174,48,37,104,45,74,60,169,44,228,81,227,5,204,147,181,192,55,37,41,144,14,57,136,205,211,193,163,15,228,74,167,237,62,151,90,148,160,171,86,145,38,101,197,55,88,194,103,155,13,161,152,98,13,243,42,104,247,104,215,12,245,5,141,189,83,225,183,144,52,253,188,67,230,167,62,56,29,237,110,48,40,124,200,99,3,52,224,205,73,53,205,246,161,86,56,246,227,250,216,55,11,134,50,13,59,230,239,33,122,30,164,24,253,126,1,253,39,49,209,107,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1d380dfa-98cc-4b28-8b3b-626ea934efae"));
		}

		#endregion

	}

	#endregion

}


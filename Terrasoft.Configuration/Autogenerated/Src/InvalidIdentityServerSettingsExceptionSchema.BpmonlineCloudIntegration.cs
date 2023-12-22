namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: InvalidIdentityServerSettingsExceptionSchema

	/// <exclude/>
	public class InvalidIdentityServerSettingsExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public InvalidIdentityServerSettingsExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public InvalidIdentityServerSettingsExceptionSchema(InvalidIdentityServerSettingsExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("45eac23e-2e39-4284-bb79-03c123cf30e3");
			Name = "InvalidIdentityServerSettingsException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fc1a2769-1cc9-44d3-a1a6-003d1b8450f5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,82,205,106,194,64,16,62,87,240,29,6,189,40,88,31,64,177,135,6,15,57,20,132,244,86,138,172,201,24,6,214,221,48,187,145,90,241,221,59,102,55,154,218,30,164,52,167,204,55,153,239,143,24,181,67,87,169,28,225,21,153,149,179,91,63,77,172,217,82,89,179,242,100,205,244,185,218,89,163,201,96,162,109,93,164,198,99,25,54,253,222,177,223,123,168,29,153,18,178,131,243,184,155,247,123,130,12,25,75,89,67,162,149,115,51,72,205,94,105,42,210,2,141,39,127,200,144,247,200,25,122,47,119,110,249,145,99,21,200,228,242,77,150,36,31,127,170,141,198,209,248,93,160,170,222,104,202,33,63,115,221,73,5,51,232,208,62,156,77,94,61,89,227,60,215,185,183,44,214,86,13,121,35,221,10,221,39,49,26,67,67,123,250,203,173,24,56,87,38,189,59,85,226,88,236,110,148,195,209,101,254,47,230,201,181,6,32,99,144,47,227,173,230,228,199,190,235,97,136,166,8,245,197,57,118,185,98,91,33,123,194,223,155,180,98,145,169,64,136,174,94,130,22,44,158,96,208,6,129,144,4,92,140,2,228,192,88,15,77,90,120,20,188,89,215,172,39,242,11,144,28,165,5,88,142,239,25,230,140,126,48,255,38,27,213,150,204,150,19,43,242,71,40,209,207,225,4,11,24,80,212,93,83,40,116,221,10,183,36,55,89,67,3,93,80,144,238,243,5,224,178,243,83,63,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("45eac23e-2e39-4284-bb79-03c123cf30e3"));
		}

		#endregion

	}

	#endregion

}


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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,82,205,106,194,64,16,62,87,240,29,6,189,40,88,31,64,177,135,6,15,57,20,132,244,86,138,172,201,24,6,214,221,48,187,145,90,241,221,59,201,110,212,218,30,164,52,167,204,55,153,239,143,24,181,67,87,169,28,225,21,153,149,179,91,63,77,172,217,82,89,179,242,100,205,244,185,218,89,163,201,96,162,109,93,164,198,99,25,54,253,222,177,223,123,168,29,153,18,178,131,243,184,155,247,123,130,12,25,75,89,67,162,149,115,51,72,205,94,105,42,210,2,141,39,127,200,144,247,200,25,122,47,119,110,249,145,99,21,200,228,242,77,150,36,31,127,170,141,198,209,248,93,160,170,222,104,202,33,111,184,238,164,130,25,92,209,62,52,38,47,158,172,113,158,235,220,91,22,107,171,150,188,149,238,132,238,147,24,141,161,165,61,253,229,86,12,52,149,73,239,78,149,56,22,187,27,229,112,116,158,255,139,121,114,169,1,200,24,228,243,120,171,57,249,177,191,246,48,68,83,132,250,226,28,187,92,177,173,144,61,225,239,77,90,177,200,84,32,68,87,47,65,11,22,79,48,232,130,64,72,2,46,70,1,114,96,172,135,54,45,60,10,222,174,107,214,19,249,5,72,142,210,2,44,199,247,12,115,70,63,152,127,147,141,106,75,102,203,137,21,249,35,148,232,231,112,130,5,12,40,234,174,41,20,186,238,132,59,146,155,172,161,129,107,80,144,230,249,2,126,190,245,196,55,3,0,0 };
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


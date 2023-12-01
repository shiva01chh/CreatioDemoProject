namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMLProblemTypeFeaturesSchema

	/// <exclude/>
	public class IMLProblemTypeFeaturesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMLProblemTypeFeaturesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMLProblemTypeFeaturesSchema(IMLProblemTypeFeaturesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("af781143-48a0-4837-b191-06bc575a6ccb");
			Name = "IMLProblemTypeFeatures";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b54cb82a-9c72-40e4-855f-14a0ef44684e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,142,77,106,3,49,12,70,215,9,228,14,90,166,155,153,3,180,116,19,40,9,36,180,139,92,64,227,202,19,131,109,25,89,94,132,144,187,87,51,249,33,80,131,12,54,223,247,244,50,38,170,5,29,193,145,68,176,178,215,110,195,217,135,177,9,106,224,220,29,246,171,229,101,181,92,244,125,15,31,181,165,132,114,254,188,191,119,89,73,252,212,246,44,80,80,52,184,22,81,192,19,106,19,170,192,30,244,68,80,11,185,224,131,131,34,60,68,74,160,231,66,221,131,218,191,96,75,27,162,229,194,147,188,59,236,127,110,165,163,117,190,238,96,75,154,148,221,255,188,230,143,45,218,234,166,165,41,172,21,101,36,125,3,199,177,165,60,155,38,254,165,8,42,24,114,200,99,247,196,188,138,44,6,230,56,129,190,103,206,230,214,190,128,177,222,225,106,1,155,235,164,96,231,15,91,149,146,90,70,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("af781143-48a0-4837-b191-06bc575a6ccb"));
		}

		#endregion

	}

	#endregion

}


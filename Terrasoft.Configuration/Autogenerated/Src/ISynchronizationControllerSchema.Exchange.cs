﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISynchronizationControllerSchema

	/// <exclude/>
	public class ISynchronizationControllerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISynchronizationControllerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISynchronizationControllerSchema(ISynchronizationControllerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1d2bb6b3-89a8-4d3d-b77f-083b86d861c6");
			Name = "ISynchronizationController";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,144,193,110,194,48,12,134,207,173,212,119,176,180,59,189,143,105,23,196,1,174,240,2,110,234,182,145,18,167,178,29,105,128,120,247,133,50,164,114,88,110,127,108,127,191,127,51,70,210,25,29,193,153,68,80,211,96,155,93,226,193,143,89,208,124,226,166,190,53,117,83,87,89,61,143,111,77,66,219,165,242,33,52,150,70,56,176,145,12,5,245,9,135,211,133,221,36,137,253,117,129,20,162,73,10,129,100,153,104,219,22,190,52,199,136,114,249,254,211,187,128,170,164,96,19,26,248,56,7,138,196,246,208,94,193,191,208,224,144,161,35,80,10,228,140,122,64,5,125,247,130,9,185,47,78,186,121,57,181,43,171,57,119,193,187,21,240,255,85,161,228,56,166,110,255,67,46,91,42,155,87,229,18,213,253,153,153,184,127,198,126,200,242,183,126,191,148,233,90,181,84,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1d2bb6b3-89a8-4d3d-b77f-083b86d861c6"));
		}

		#endregion

	}

	#endregion

}


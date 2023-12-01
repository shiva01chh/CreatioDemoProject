﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EntityDataActualizerSchema

	/// <exclude/>
	public class EntityDataActualizerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EntityDataActualizerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EntityDataActualizerSchema(EntityDataActualizerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3317f2e4-9926-4190-824a-94270c7e1867");
			Name = "EntityDataActualizer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("de8ae9a8-a9a7-4323-ba50-b61a787183b3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,85,77,111,219,48,12,61,187,64,255,3,225,93,90,32,112,238,75,99,160,95,27,134,161,195,128,110,231,64,149,233,68,152,45,27,146,220,46,45,246,223,71,201,150,107,57,118,154,30,210,136,226,199,227,227,163,34,89,137,186,102,28,225,23,42,197,116,149,155,228,182,146,185,216,54,138,25,81,73,56,63,123,59,63,139,26,45,228,22,30,247,218,96,185,26,157,41,160,40,144,91,111,157,124,69,137,74,240,119,159,97,94,133,115,246,176,232,172,215,221,205,236,213,189,52,194,8,212,228,64,46,159,20,110,45,250,219,130,105,253,25,220,229,254,142,25,118,205,77,195,10,241,138,202,249,45,151,75,184,210,77,89,50,181,79,187,51,65,49,170,42,52,160,139,130,140,194,128,185,184,87,7,47,241,129,203,65,100,221,60,21,130,3,183,5,39,235,17,147,209,155,43,218,163,251,34,176,200,8,222,79,37,158,153,193,246,114,12,169,51,32,2,87,152,175,227,223,26,21,65,148,45,227,241,50,5,33,181,97,146,99,210,123,15,129,69,117,155,29,194,64,216,52,193,121,53,91,219,182,1,248,215,40,226,160,82,11,120,217,9,190,243,134,150,29,33,65,215,200,69,78,12,228,149,42,153,73,224,56,152,119,134,238,125,102,216,100,193,241,13,182,104,86,160,237,199,191,89,116,247,131,33,113,154,28,225,242,16,89,93,23,221,141,169,220,255,39,166,63,98,169,205,231,199,198,8,136,5,121,219,102,134,13,246,184,189,105,4,211,205,23,101,214,142,56,156,55,133,104,163,26,219,157,157,186,83,204,145,161,127,147,164,104,39,158,73,65,205,52,226,44,53,83,172,4,73,219,189,142,195,57,199,233,72,7,189,122,174,150,46,106,58,73,48,154,56,157,26,159,79,100,21,224,216,38,74,188,76,236,214,28,205,127,192,171,175,49,55,137,201,106,110,226,65,161,110,45,167,248,187,176,247,209,136,141,144,172,133,83,113,52,213,109,64,200,98,224,54,7,248,160,195,75,232,158,131,40,26,237,34,172,97,98,57,201,45,92,144,117,8,194,59,29,74,116,125,88,124,21,69,214,253,3,193,62,160,217,85,217,41,90,237,105,13,94,205,23,97,118,253,112,130,119,3,51,200,85,85,78,190,3,62,231,211,126,112,237,123,177,43,156,1,97,43,105,216,246,119,64,53,5,234,83,119,225,15,238,233,215,170,41,229,15,58,198,169,253,132,42,247,152,191,251,219,83,180,250,200,119,88,178,201,60,218,93,29,79,194,93,33,253,208,118,17,167,109,97,221,183,117,146,172,159,43,145,189,83,127,65,143,139,13,13,154,92,64,103,29,163,94,192,157,112,226,34,178,174,90,31,239,155,66,136,206,41,149,164,245,204,90,76,143,104,53,21,170,49,233,190,217,89,93,92,182,90,60,148,98,114,109,91,113,62,135,120,70,184,67,12,11,95,185,205,61,33,220,206,54,52,145,133,254,254,3,56,84,96,174,229,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3317f2e4-9926-4190-824a-94270c7e1867"));
		}

		#endregion

	}

	#endregion

}


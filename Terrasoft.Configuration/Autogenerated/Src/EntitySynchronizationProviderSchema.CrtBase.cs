﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EntitySynchronizationProviderSchema

	/// <exclude/>
	public class EntitySynchronizationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EntitySynchronizationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EntitySynchronizationProviderSchema(EntitySynchronizationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("892b44f1-d74d-4dc3-bf0c-55de0813ea7c");
			Name = "EntitySynchronizationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,86,77,111,26,49,16,61,111,164,252,7,43,189,44,18,90,238,129,32,37,16,42,212,166,161,37,105,143,149,179,59,128,171,93,27,108,111,34,26,229,191,119,252,177,176,94,22,210,67,203,9,207,206,199,155,55,207,35,115,90,128,90,211,20,200,3,72,73,149,88,232,100,36,248,130,45,75,73,53,19,60,185,229,154,233,237,124,203,211,149,20,156,253,182,214,243,179,215,243,179,243,179,168,84,140,47,201,124,171,52,20,24,151,231,144,154,207,42,249,8,28,36,75,251,77,159,207,140,111,246,198,122,77,9,199,236,14,2,3,213,238,80,20,130,247,45,154,15,18,150,88,157,140,114,170,212,37,105,69,62,147,226,153,101,32,109,64,175,215,35,3,85,22,5,149,219,161,63,123,7,69,192,134,147,133,144,68,133,57,146,42,180,87,139,93,151,79,57,75,73,106,106,159,46,77,46,201,244,29,108,145,163,119,215,209,132,65,158,97,75,51,201,158,169,6,247,177,137,222,26,30,21,22,72,5,231,110,18,201,206,177,142,53,90,187,60,214,123,180,115,38,63,203,224,220,247,32,128,103,14,71,8,234,14,244,74,88,84,182,117,247,209,211,112,178,191,184,81,54,172,218,33,175,38,81,212,0,67,174,200,1,186,40,122,59,65,197,72,130,233,209,207,81,44,170,127,42,93,65,65,201,11,211,43,194,81,255,100,176,166,146,22,18,22,246,120,117,225,252,230,214,237,11,90,46,134,71,104,180,22,27,124,52,242,54,168,105,188,146,65,207,134,236,51,72,208,165,228,106,232,0,103,30,39,250,85,31,14,136,245,189,185,67,172,180,52,151,162,89,188,75,158,132,200,13,107,215,89,193,248,55,182,92,105,133,52,46,104,174,160,98,249,182,22,20,100,64,199,198,4,146,186,239,29,229,116,9,50,153,48,158,77,185,210,148,167,112,179,53,101,227,38,142,78,159,216,82,108,65,226,176,194,21,225,101,158,87,80,34,215,174,181,217,225,154,233,238,32,86,211,187,10,80,38,1,17,13,192,29,151,197,211,57,7,61,134,5,46,169,178,224,223,105,94,130,138,67,135,199,38,81,33,115,206,215,99,116,33,239,74,208,176,115,106,147,16,183,206,154,2,196,251,155,49,187,72,255,183,244,234,25,234,85,231,64,101,186,34,59,211,113,209,78,68,201,255,74,178,134,139,247,4,59,102,118,112,216,228,192,249,116,137,120,250,133,211,28,238,161,168,80,186,123,93,4,82,56,20,33,70,52,100,152,76,64,167,171,137,20,197,248,38,174,229,111,10,178,54,108,47,201,166,82,223,90,150,223,191,107,184,235,208,180,248,222,75,92,167,99,38,157,222,135,68,152,243,205,214,137,124,71,212,51,149,4,212,6,41,226,240,66,234,183,248,107,9,242,224,218,180,221,243,238,1,246,234,238,168,77,114,157,101,215,121,238,62,249,210,213,213,66,205,3,69,33,197,159,96,107,47,221,140,50,121,188,85,194,120,203,160,163,233,1,230,9,203,53,200,41,62,41,208,223,84,116,6,179,29,16,144,83,130,51,253,192,53,63,51,210,5,60,168,216,25,241,213,128,114,102,74,240,135,237,26,31,24,155,146,230,158,229,104,175,121,196,220,173,93,1,139,223,247,101,251,118,185,148,233,63,174,163,232,212,165,114,154,129,147,3,52,108,180,79,52,58,32,196,71,56,24,21,13,46,8,31,99,218,175,230,32,155,233,175,106,199,197,37,33,28,76,19,6,88,252,135,171,121,255,240,115,42,193,167,154,71,128,149,155,46,71,150,116,253,170,97,60,114,43,149,190,151,184,177,105,153,107,47,167,183,214,7,137,179,134,70,107,51,191,63,8,45,126,113,225,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("892b44f1-d74d-4dc3-bf0c-55de0813ea7c"));
		}

		#endregion

	}

	#endregion

}


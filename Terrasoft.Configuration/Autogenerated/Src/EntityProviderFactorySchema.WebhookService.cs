﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EntityProviderFactorySchema

	/// <exclude/>
	public class EntityProviderFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EntityProviderFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EntityProviderFactorySchema(EntityProviderFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1c89d4c0-70ca-4a8d-8432-7deff22d057d");
			Name = "EntityProviderFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e50fad81-60b2-4030-89a7-8b387fd6a892");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,85,93,79,219,48,20,125,14,18,255,225,174,155,88,145,80,242,14,165,18,234,96,66,26,27,26,76,123,100,110,114,83,172,37,118,102,59,101,21,226,191,239,218,206,119,19,70,31,218,228,246,126,156,156,123,142,35,88,142,186,96,49,194,61,42,197,180,76,77,184,146,34,229,155,82,49,195,165,56,60,120,62,60,8,74,205,197,6,238,118,218,96,126,54,184,167,252,44,195,216,38,235,240,51,10,84,60,222,203,249,194,197,159,54,216,157,165,112,42,30,94,177,216,72,197,81,83,6,229,188,87,184,161,33,176,202,152,214,167,112,41,12,55,187,91,37,183,60,65,229,115,119,46,49,138,34,88,232,50,207,153,218,45,171,251,251,71,132,212,231,128,76,1,93,49,20,85,181,14,235,178,168,83,87,148,235,140,199,16,219,121,83,227,130,103,55,50,40,20,223,50,131,160,13,209,22,195,245,79,92,63,74,249,187,95,5,15,9,166,172,204,76,29,56,27,43,189,20,101,142,138,173,51,92,140,183,89,194,67,3,220,83,211,114,67,75,48,170,180,224,136,162,91,247,0,62,99,72,138,11,116,210,155,156,104,152,180,40,152,98,57,8,146,202,249,172,212,168,168,74,248,133,207,150,150,87,27,131,184,9,134,139,200,85,184,6,21,135,163,236,205,127,244,154,65,191,247,49,88,229,5,193,144,51,56,7,129,79,48,202,204,124,208,194,241,251,82,81,132,34,241,44,245,41,163,218,2,149,33,153,17,97,126,21,253,149,190,101,33,245,149,174,64,111,208,84,87,1,79,97,222,238,11,222,17,252,50,203,224,232,168,179,197,240,66,236,230,199,245,19,7,129,66,83,42,209,95,179,141,191,248,159,189,191,137,19,231,138,138,88,178,161,185,200,178,41,180,115,207,139,239,246,31,118,110,208,60,202,228,45,90,162,153,26,12,201,225,201,15,29,122,44,124,163,194,124,217,87,186,158,45,237,183,181,171,109,235,227,61,113,141,169,243,83,95,45,179,37,137,12,42,9,53,88,128,150,146,72,241,203,64,42,75,145,180,241,245,174,134,109,27,190,58,139,206,42,169,110,80,107,182,65,239,3,23,129,220,135,94,7,250,52,182,152,217,242,59,106,130,185,87,233,247,173,221,16,93,96,204,83,142,201,30,191,139,168,206,235,24,111,45,101,6,247,106,71,219,25,119,12,249,223,30,189,45,235,39,32,75,51,117,128,141,226,62,113,106,178,85,117,179,14,53,39,30,194,254,102,106,181,119,147,193,155,195,203,115,2,66,209,158,3,141,235,194,43,174,180,249,166,170,17,243,191,112,190,244,86,249,27,94,54,79,166,237,171,205,48,46,244,188,251,184,119,14,244,74,230,196,58,209,120,45,182,76,113,38,204,138,58,149,10,175,55,130,94,70,43,166,241,184,242,141,117,116,131,162,242,115,227,221,81,134,8,107,209,61,242,27,11,211,225,139,29,51,186,214,211,84,77,54,31,125,175,76,14,153,234,210,82,63,216,201,135,217,138,137,143,6,20,106,153,109,177,99,199,118,27,41,73,223,140,232,211,114,124,10,207,237,205,75,56,243,67,42,116,41,203,52,190,114,80,251,104,63,232,98,221,207,63,93,150,87,91,200,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1c89d4c0-70ca-4a8d-8432-7deff22d057d"));
		}

		#endregion

	}

	#endregion

}


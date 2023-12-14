﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EsnMessageDTOSchema

	/// <exclude/>
	public class EsnMessageDTOSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EsnMessageDTOSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EsnMessageDTOSchema(EsnMessageDTOSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6c636fc5-728b-4126-9e55-9608ee750af1");
			Name = "EsnMessageDTO";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,85,201,110,219,48,16,61,203,128,255,97,144,92,218,139,62,32,65,15,169,108,20,1,98,199,136,157,246,16,228,64,83,19,149,176,68,10,92,82,168,70,255,189,164,108,107,11,237,48,6,10,212,7,3,156,55,239,205,144,179,136,147,2,85,73,40,194,10,165,36,74,188,232,56,17,252,133,101,70,18,205,4,143,167,203,249,120,180,29,143,34,163,24,207,96,89,41,141,197,245,224,28,63,24,174,89,129,241,18,37,35,57,251,93,115,91,175,86,124,110,152,115,122,101,20,103,34,197,60,158,16,77,108,68,45,9,213,150,48,30,1,68,151,18,51,203,7,72,114,162,212,21,76,21,127,64,146,206,80,41,146,225,100,117,239,252,162,167,46,245,217,26,74,179,206,25,5,234,72,62,78,228,174,209,136,47,164,40,81,106,134,54,192,162,102,214,170,59,217,25,22,107,148,159,230,246,121,224,11,92,220,166,23,159,93,132,67,136,111,134,165,112,155,194,22,50,212,215,160,220,223,159,227,244,68,20,5,114,157,8,251,74,125,33,198,53,116,209,96,69,137,68,99,250,181,234,203,217,75,55,200,68,11,104,14,67,221,40,122,71,249,158,247,149,149,150,174,144,13,26,154,232,29,81,250,134,186,110,56,162,216,117,8,21,157,218,102,211,149,183,40,7,40,84,106,223,31,222,212,246,216,199,178,90,210,159,88,144,199,19,201,53,30,231,8,59,155,55,217,161,83,120,197,187,204,132,148,174,20,239,70,216,251,5,119,1,219,224,145,238,111,160,112,45,190,89,72,124,101,248,203,161,125,197,117,165,241,233,25,6,62,161,210,11,34,113,152,227,157,16,27,83,38,34,55,5,255,78,114,131,176,243,10,159,253,92,72,255,44,57,36,84,230,81,161,188,161,212,118,228,219,39,108,49,159,218,37,242,116,183,242,236,105,103,235,154,220,241,237,186,253,33,153,198,143,238,219,1,9,14,27,247,31,108,212,83,83,118,230,124,253,111,235,228,188,138,159,174,112,91,224,238,103,34,172,186,189,15,203,149,103,46,182,199,150,140,189,204,170,42,49,173,221,60,143,220,130,222,165,229,187,81,109,115,191,191,46,15,148,147,193,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6c636fc5-728b-4126-9e55-9608ee750af1"));
		}

		#endregion

	}

	#endregion

}


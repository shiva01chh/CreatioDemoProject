﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MktgActivityEventListenerSchema

	/// <exclude/>
	public class MktgActivityEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MktgActivityEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MktgActivityEventListenerSchema(MktgActivityEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f422b227-295e-4b88-a5ba-a89b4c239fc0");
			Name = "MktgActivityEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0d7ed7ad-953f-4448-9eef-c702acc0afc1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,84,77,143,211,48,16,61,119,165,253,15,163,112,73,164,149,115,239,38,149,202,170,192,74,44,139,246,227,132,56,184,206,36,49,36,118,101,59,129,106,197,127,199,177,155,82,71,205,2,189,180,51,158,55,243,222,179,167,130,182,168,119,148,33,60,161,82,84,203,210,144,27,41,74,94,117,138,26,46,197,229,197,203,229,197,162,211,92,84,65,137,194,235,153,60,217,8,195,13,71,253,215,2,178,214,123,193,238,119,232,71,253,63,128,220,10,131,170,180,244,255,1,187,233,81,152,249,186,119,148,25,169,60,109,91,243,70,97,101,71,192,77,67,181,94,194,221,119,83,173,153,225,61,55,123,215,232,35,215,6,5,42,87,156,166,41,100,186,107,91,170,246,171,67,60,22,64,41,85,0,7,28,24,217,47,199,135,140,240,116,130,207,52,34,109,180,4,166,176,204,163,215,85,145,183,84,163,203,133,236,34,72,135,126,95,206,28,197,143,172,198,150,126,178,15,0,114,136,78,25,70,201,87,11,218,117,219,134,51,96,131,1,243,250,97,9,51,179,109,139,23,231,206,209,203,59,52,181,44,172,155,159,93,107,127,56,245,206,37,62,80,81,52,168,71,171,30,105,143,133,55,140,28,49,233,20,148,237,168,162,45,8,171,40,143,52,138,194,234,95,57,74,224,35,146,165,174,228,60,2,163,213,83,141,206,247,209,243,229,172,235,142,215,186,180,175,207,13,88,171,74,15,94,3,23,218,80,97,215,137,73,97,40,23,195,67,51,53,142,3,157,4,40,168,161,1,151,131,213,178,183,227,120,129,208,75,94,192,189,112,178,99,185,253,134,108,148,112,5,231,70,3,38,48,172,233,98,177,181,119,65,70,228,8,193,228,218,29,62,107,84,118,185,133,109,55,92,71,23,134,57,196,177,111,158,120,96,66,66,128,111,114,123,114,213,110,29,55,63,145,117,118,117,128,6,81,238,87,199,175,213,158,188,71,147,205,66,87,177,192,31,96,39,105,163,186,161,222,138,234,90,91,21,71,33,201,232,106,194,58,57,72,155,118,62,254,71,56,123,100,16,229,48,76,123,21,49,113,226,143,133,129,70,226,127,160,195,103,167,43,242,192,171,218,232,7,172,186,134,58,125,1,3,223,235,215,97,57,236,4,191,31,46,246,217,48,233,114,167,159,223,59,92,31,133,182,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f422b227-295e-4b88-a5ba-a89b4c239fc0"));
		}

		#endregion

	}

	#endregion

}


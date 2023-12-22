﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EventTargetPostProcessHandlerSchema

	/// <exclude/>
	public class EventTargetPostProcessHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EventTargetPostProcessHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EventTargetPostProcessHandlerSchema(EventTargetPostProcessHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("019f4e9e-5304-491b-b2a4-699f10d54713");
			Name = "EventTargetPostProcessHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5b53fbff-9be6-434d-a91a-0bac8907d8d7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,84,77,111,226,48,16,61,83,169,255,97,148,189,4,137,77,238,229,227,176,20,40,135,74,72,116,213,67,181,7,227,12,33,82,108,103,109,135,110,85,237,127,223,177,157,164,132,46,168,156,50,51,158,55,111,158,159,145,76,160,169,24,71,120,66,173,153,81,123,155,204,149,220,23,121,173,153,45,148,76,86,40,145,62,49,123,198,221,82,105,177,69,125,44,56,38,115,38,42,86,228,210,220,222,188,223,222,12,106,83,200,28,182,111,198,162,24,119,241,92,105,236,71,201,253,143,143,196,165,153,45,118,51,139,26,168,229,155,198,156,138,48,47,153,49,119,176,56,162,180,79,76,231,104,55,202,216,141,86,28,141,121,96,50,43,81,251,134,52,77,97,98,106,33,152,126,155,53,241,90,84,37,10,234,52,84,66,4,174,113,63,141,46,241,88,159,47,255,121,82,4,233,12,246,74,67,69,165,239,85,168,185,221,154,129,121,139,0,175,184,115,7,133,63,125,194,62,105,169,166,39,92,171,122,87,22,28,184,219,245,250,170,112,7,95,160,73,144,239,94,148,78,198,71,180,7,149,145,144,27,93,28,169,55,84,171,16,192,170,46,50,88,161,37,61,44,227,118,157,197,63,13,106,138,36,114,39,13,212,189,112,20,26,240,131,232,58,27,130,243,197,96,112,100,26,12,150,116,16,166,32,241,21,182,62,136,251,8,67,127,118,64,23,80,214,66,198,81,55,56,106,43,75,173,68,28,157,104,209,85,158,15,168,49,142,220,217,100,109,22,191,107,86,198,1,39,217,48,77,14,183,168,227,62,183,33,48,211,16,25,123,20,141,182,214,178,33,154,44,254,32,175,45,110,57,43,153,158,184,221,102,241,208,31,252,219,168,136,50,11,66,94,82,213,95,96,40,158,27,209,39,154,17,6,236,1,189,121,224,196,60,206,34,166,66,94,236,11,114,78,73,119,232,178,21,203,49,233,0,211,115,196,73,229,150,5,73,11,79,163,190,186,209,236,137,166,184,28,240,46,153,76,82,223,241,127,128,102,40,137,234,123,91,14,69,70,50,58,90,250,122,187,115,250,61,179,44,116,123,223,103,20,94,111,234,221,81,232,244,41,176,62,119,105,120,243,88,142,138,44,216,200,250,37,187,118,43,142,192,189,154,101,129,101,102,28,233,151,95,208,242,31,5,143,93,182,183,175,240,214,173,100,241,222,171,57,159,219,135,24,119,15,68,32,165,30,176,172,232,134,194,43,57,127,211,161,248,9,176,219,161,1,59,1,74,30,221,119,203,69,90,213,254,173,198,29,221,107,158,14,217,126,210,231,78,127,255,0,48,17,239,56,64,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("019f4e9e-5304-491b-b2a4-699f10d54713"));
		}

		#endregion

	}

	#endregion

}


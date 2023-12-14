﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseTermStrategyManagerSchema

	/// <exclude/>
	public class CaseTermStrategyManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseTermStrategyManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseTermStrategyManagerSchema(CaseTermStrategyManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("440b9a6b-8041-449a-a3df-fa264f479282");
			Name = "CaseTermStrategyManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f69a32ba-7e77-47bd-be6b-d095bbdc629a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,83,193,110,219,48,12,61,187,64,255,129,200,46,9,96,216,247,197,49,208,101,104,145,67,183,14,233,176,195,176,131,226,208,174,54,91,14,40,57,133,17,244,223,71,73,182,235,120,9,230,131,33,74,143,79,143,228,147,18,21,234,131,200,16,158,145,72,232,58,55,209,186,86,185,44,26,18,70,214,234,246,230,116,123,19,52,90,170,2,182,173,54,88,45,39,49,227,203,18,51,11,214,209,3,42,36,153,189,99,198,180,132,209,189,200,76,77,18,245,53,4,239,243,201,7,194,130,249,96,93,10,173,63,194,90,104,100,88,181,53,44,10,139,246,81,40,81,32,57,104,28,199,144,232,166,170,4,181,105,23,91,60,104,15,230,187,160,242,248,168,135,199,35,252,207,175,71,22,32,247,248,139,131,67,179,43,101,6,153,189,246,250,173,193,201,221,60,168,124,68,243,82,239,89,231,147,75,247,135,83,93,110,195,35,193,188,8,3,132,166,33,165,65,42,109,132,226,9,212,121,175,185,237,20,236,90,80,60,160,104,224,139,167,132,201,65,144,168,28,106,53,115,73,95,120,57,75,237,223,18,122,114,35,153,117,239,73,163,36,118,57,151,41,4,21,77,133,202,232,89,122,215,47,33,175,105,162,236,95,146,174,154,116,123,94,65,95,28,39,244,8,155,210,245,249,40,201,52,162,132,79,147,78,39,125,235,55,202,32,29,69,25,142,134,193,8,157,194,3,154,13,155,111,206,186,172,137,134,210,67,248,44,157,23,185,75,137,63,12,161,222,253,102,131,166,48,84,23,90,17,193,119,141,196,102,87,222,188,208,156,133,11,56,57,208,81,16,188,214,244,199,189,146,231,246,128,79,84,31,217,46,4,43,111,79,111,233,150,173,111,146,205,143,75,200,116,190,88,58,46,187,233,165,186,213,234,50,177,101,178,241,124,40,170,75,151,57,204,71,217,43,80,77,89,246,58,3,223,95,183,231,225,111,238,223,53,136,179,176,218,149,173,51,198,234,93,68,116,215,29,124,227,65,200,92,226,222,34,150,67,233,89,67,196,29,27,198,58,41,250,190,166,12,109,229,255,31,161,163,156,140,49,157,143,117,133,160,240,21,120,4,172,185,177,252,189,5,231,179,243,217,204,194,233,176,60,123,16,92,37,224,209,107,78,27,28,176,232,122,218,117,109,82,166,59,123,235,94,57,170,189,127,232,28,217,158,142,55,56,182,223,95,180,71,149,16,71,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("440b9a6b-8041-449a-a3df-fa264f479282"));
		}

		#endregion

	}

	#endregion

}


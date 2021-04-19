// GlobalCalibration_Algorithm.cpp : 定义 DLL 应用程序的导出函数。
//



#include "stdafx.h"
#include "GlobalCalibration_Algorithm.h"

#include "PoseCalibImpl.h"

PoseCalib::PoseCalib()
{
	pImpl = new PoseCalibImpl();
}

PoseCalib::~PoseCalib()
{
	delete pImpl;
}

void  PoseCalib::InitData()
{
	pImpl->InitData_impl();
}

bool PoseCalib:: AddPointCloud(XDPOINT* pts, int num, std::string& errorInfo)
{	
	return (pImpl->AddPointCloud_impl(pts, num, errorInfo));
}

bool PoseCalib::AddTrajInfo(double* pos, int num, std::string& errorInfo)
{
	return (pImpl->AddTrajInfo_impl(pos, num, errorInfo));
}

void PoseCalib::SetInitPose(double x, double y, double z)
{
	pImpl->SetInitPos_impl(x, y, z);
}

void PoseCalib::SetIterateNum(int num)
{
	pImpl->SetIterateNum_impl(num);
}

void PoseCalib::SetHWndName(std::string wnd_name)
{
	pImpl->SetHWndName_impl(wnd_name);
}

bool PoseCalib::ComputeSensorPose(double* pose_array, double& final_cost, std::string& errorInfo)
{
	final_cost = 999.9;
	
	if (pImpl->ComputeSensorPose_impl(errorInfo))
	{
		final_cost = pImpl->GetFinalCost_impl();
		double* r =  pImpl->GetResultPose_impl();
		pose_array[0] = r[0];
		pose_array[1] = r[1];
		pose_array[2] = r[2];
		return true;
	}
	else
		return false;	
}

void PoseCalib::SetSensorLineDir(bool isPositive)
{
	pImpl->SetSensorLineDir_impl(isPositive);
}

void PoseCalib::AddSensorMoveAxis(int axis_index)
{
	pImpl->AddSensorMoveAxis_impl(axis_index);
}

void PoseCalib::SetScanMoveAxis(int axis_index)
{
	pImpl->SetScanMoveAxis_impl(axis_index);
}

void PoseCalib::SetAxisDir(int axis_index, bool is_positive)
{
	pImpl->SetAxisDir_impl(axis_index, is_positive);
}


bool PoseCalib::SavePoseMatrix(std::string file_name, std::string& errorInfo)
{
	return pImpl->SavePoseMatrix_impl(file_name, errorInfo);
}

bool PoseCalib::GetTransedPointCloud(int index, XDPOINT* pts, std::string& errorInfo)
{
	return pImpl->GetTransedPointCloud_impl(index, pts, errorInfo);
}

int PoseCalib::GetSinglePointCloudNum(int index)
{
	return pImpl->GetSinglePointCloudNum_impl(index);
}

void PoseCalib::GetTransedPointCloudFitInfo(int index, XDPOINT& center, double& radius)
{
	pImpl->GetSphereFitInfo_impl(index, center, radius);
}

//*************************************************************
//                  Exported Function
//*************************************************************

PoseCalib* CreatePoseCalibInstance()
{	
	return new PoseCalib();
}

void DestroyPoseCalibInstance(PoseCalib* pInstance)
{
	pInstance->~PoseCalib();	
}

// 将string 类型转换为char**, 用于输出错误信息给C#调用
void ModifyCharPointer(const std::string str, char** ptr)
{
	*ptr = new char[str.length() + 1];
	strcpy(*ptr, str.c_str());	
}

bool AddPointCloud(PoseCalib* pInstance, XDPOINT* pts, int num, char** errorInfo)
{
	std::string str;
	if (pInstance->AddPointCloud(pts, num, str))
	{			
		return true;
	}
	else
	{
		ModifyCharPointer(str, errorInfo);
		return false;
	}
}

bool AddTrajInfo(PoseCalib* pInstance, double* pts, int num, char** errorInfo)
{
	std::string str;
	if (pInstance->AddTrajInfo(pts, num, str))
	{		
		return true;
	}
		
	else
	{
		ModifyCharPointer(str, errorInfo);
		return false;
	}
}

void SetInitPose(PoseCalib* pInstance,  double x, double y, double z)
{
	pInstance->SetInitPose(x, y, z);
}

bool ComputeSensorPose(PoseCalib* pInstance, double* pose_array, double& final_cost, char** errorInfo)
{
	std::string str;
	if (pInstance->ComputeSensorPose(pose_array, final_cost, str))
		return true;
	else
	{
		ModifyCharPointer(str, errorInfo);
		return false;
	}	
}

void AddSensorMoveAxis(PoseCalib* pInstance, int axis_index)
{
	pInstance->AddSensorMoveAxis(axis_index);
}

void SetScanMoveAxis(PoseCalib* pInstance, int axis_index)
{
	pInstance->SetScanMoveAxis(axis_index);
}

void SetAxisDir(PoseCalib* pInstance, int axis_index, bool is_positive)
{
	pInstance->SetAxisDir(axis_index, is_positive);
}

void SetSensorLineDir(PoseCalib* pInstance, bool isPositive)
{
	pInstance->SetSensorLineDir(isPositive);
}

bool SavePoseMatrix(PoseCalib* pInstance, const char* file_name, char** errorInfo)
{
	std::string str(file_name);
	if (pInstance->SavePoseMatrix(str, str))
		return true;
	else
	{
		ModifyCharPointer(str, errorInfo);
		return false;
	}
}

bool GetTransedPointCloud(PoseCalib* pInstance, int index, XDPOINT* pts, char** errorInfo)
{
	std::string str;

	if (pInstance->GetTransedPointCloud(index, pts, str))
		return true;
	else
	{
		ModifyCharPointer(str, errorInfo);
		return false;
	}	
}

int GetSinglePointCloudNum(PoseCalib* pInstance, int index)
{
	return pInstance->GetSinglePointCloudNum(index);
}

void InitData(PoseCalib* pInstance)
{
	pInstance->InitData();
}

void SetIterateNum(PoseCalib* pInstance, int num)
{
	pInstance->SetIterateNum(num);
}

void GetTransedPointCloudFitInfo(PoseCalib* pInstance, int index, XDPOINT& center, double& radius)
{
	pInstance->GetTransedPointCloudFitInfo(index, center, radius);
}


void SetHWndName(PoseCalib* pInstance, const char* wnd_name)
{
	std::string str(wnd_name);
	pInstance->SetHWndName(str);
}
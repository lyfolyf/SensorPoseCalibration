#pragma once
//#pragma unmanaged

#include <vector>
#include "GlobalCalibration_Algorithm.h"


std::vector<double> SolveSensorsPose(const std::vector<std::vector<XDPOINT>>& pointclouds, const std::vector<std::vector<double>>& Axis_Info, std::vector<double> Pose_Initial, std::string& SolverSummaryReport, bool IsAutoCalib, bool IsScanAlongX, int iter_num, std::string ProcessBarName);

void GetSphereInfo(const std::vector<XDPOINT>& pointcloud, XDPOINT& center, double& radius);
#pragma once

namespace Server_Library
{
	class Praise2_Input
	{
	public:
		Praise2_Input();
		virtual ~Praise2_Input();

		double GetPlayer_Position_X();
		double GetPlayer_Position_Y();
		double GetPlayer_Position_Z();

		void SetPlayer_Position_X(double value);
		void SetPlayer_Position_Y(double value);
		void SetPlayer_Position_Z(double value);

	protected:

	private:
		static double _player_position_X;
		static double _player_position_Y;
		static double _player_position_Z;
	};
}
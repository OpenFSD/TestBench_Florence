#pragma once
#include "Framework_Server.h"
#include "Praise0_Algorithm.h"

namespace Server_Library
{
    class Concurrent_Control
    {
    public:
        Concurrent_Control();
        virtual ~Concurrent_Control();
        void SelectSet_Algorithm_Subset_For_Given_PraiseEventId(
            __int16 ptr_praiseEventId,
            __int8 concurrent_coreId
        );

    protected:

    private:

    };
}
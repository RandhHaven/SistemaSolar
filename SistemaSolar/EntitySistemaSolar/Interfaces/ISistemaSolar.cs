﻿using System.Collections.Generic;

namespace EntitySistemaSolar.Interfaces
{
    public interface ISistemaSolar
    {
        void Initialize(int anios);

        List<SistemaMeteorologicoBase> CargarSistemaMeteorologico();
    }
}

using DataAccessLayer.Repository;
using DTO.Model;

namespace BusinessLayer.BLL;

public class BLL
{
    

        public IEnumerable<DTO.Model.Medarbejder> hentAlleMedarbejdere()
        {
            var medarbejdere = MedarbejderRepository.hentAlleMedarbejdere();
            return medarbejdere.Select(m => new Medarbejder()
            {
                Initialer = m.Initialer,
                Navn = m.Navn,
                Cpr = m.Cpr
            });
        }

        public DTO.Model.Medarbejder hentMedarbejder(string initialer)
        {
            var medarbejder = MedarbejderRepository.hentMedarbejder(initialer);
            if (medarbejder == null)
                throw new KeyNotFoundException("Medarbejder not found");

            return new Medarbejder
            {
                Initialer = medarbejder.Initialer,
                Navn = medarbejder.Navn,
                Cpr = medarbejder.Cpr
            };
        }

        public void tilfojMedarbejder(DTO.Model.Medarbejder medarbejderDto)
        {
            var medarbejder = new Medarbejder
            {
                Initialer = medarbejderDto.Initialer,
                Navn = medarbejderDto.Navn,
                Cpr = medarbejderDto.Cpr
            };
            MedarbejderRepository.opretMedarbejder(medarbejder);
        }

        public void opdaterMedarbejder(DTO.Model.Medarbejder medarbejderDto)
        {
            var medarbejder = MedarbejderRepository.hentMedarbejder(medarbejderDto.Initialer);
            if (medarbejder == null)
                throw new KeyNotFoundException("Medarbejder not found");

            medarbejder.Navn = medarbejderDto.Navn;
            medarbejder.Cpr = medarbejderDto.Cpr;
                
            MedarbejderRepository.opdaterMedarbejder(medarbejder);
        }

        public void sletMedarbejder(string initialer)
        {
            var medarbejder = MedarbejderRepository.hentMedarbejder(initialer);
            if (medarbejder == null)
                throw new KeyNotFoundException("Medarbejder not found");

            MedarbejderRepository.sletMedarbejder(medarbejder);
        }
        
        public IEnumerable<DTO.Model.Afdeling> hentAlleAfdelinger()
        {
            var afdelinger = AfdelingRepository.hentAlleAfdelinger();
            return afdelinger.Select(a => new Afdeling()
            {
                AfdelingNavn = a.AfdelingNavn,
                AfdelingNr = a.AfdelingNr
            });
        }

        public DTO.Model.Afdeling hentAfdeling(int afdelingId)
        {
            var afdeling = AfdelingRepository.hentAfdeling(afdelingId);
            if (afdeling == null)
                throw new KeyNotFoundException("Medarbejder not found");

            return new Afdeling()
            {
                AfdelingNavn = afdeling.AfdelingNavn,
                AfdelingNr = afdeling.AfdelingNr
            };
        }

        public void tilfojAfdeling(DTO.Model.Afdeling afdelingDto)
        {
            var afdeling = new Afdeling()
            {
                AfdelingNavn = afdelingDto.AfdelingNavn,
                AfdelingNr = afdelingDto.AfdelingNr
            };
            AfdelingRepository.opretAfdeling(afdeling);
        }

        public void opdaterAfdeling(DTO.Model.Afdeling afdelingDto)
        {
            var afdeling = AfdelingRepository.hentAfdeling(afdelingDto.AfdelingNr);
            if (afdeling == null)
                throw new KeyNotFoundException("Afdeling not found");

            afdeling.AfdelingNavn = afdelingDto.AfdelingNavn;
                
            AfdelingRepository.opdaterAfdeling(afdeling);
        }
    

        public void sletAfdeling(int afdelingNr)
        {
            var afdeling = AfdelingRepository.hentAfdeling(afdelingNr);
            if (afdeling == null)
                throw new KeyNotFoundException("Afdeling not found");
        
            AfdelingRepository.sletAfdeling(afdeling);
        }

        public IEnumerable<DTO.Model.Sag> hentAlleSager()
        {
            var sager = SagRepository.hentAlleSager();
            return sager.Select(s => new Sag()
            {
                SagId = s.SagId,
                Overskrift = s.Overskrift,
                Beskrivelse = s.Beskrivelse,
            });
        }

        public DTO.Model.Sag hentSag(int sagId)
        {
            var sag = SagRepository.hentSag(sagId);
            if (sag == null)
                throw new KeyNotFoundException("Sag not found");

            return new Sag()
            {
                SagId = sag.SagId,
                Overskrift = sag.Overskrift,
                Beskrivelse = sag.Beskrivelse,
            };
        }

        public void opdaterSag(int sagId)
        {
            var sag = SagRepository.hentSag(sagId);
            if (sag == null)
                throw new KeyNotFoundException("Sag not found");

            sag.Overskrift = sag.Overskrift;
            sag.Beskrivelse = sag.Beskrivelse;
                
            SagRepository.opdaterSag(sag);
        }
        
        public void tilfojSag(DTO.Model.Sag sagDto)
        {
            var sag = new Sag()
            {
                SagId = sagDto.SagId,
                Overskrift = sagDto.Overskrift,
                Beskrivelse = sagDto.Beskrivelse
            };
            SagRepository.tilfojSag(sag);
        }
        
        public void sletSag(int sagId)
        {
            var sag = SagRepository.hentSag(sagId);
            if (sag == null)
                throw new KeyNotFoundException("Sag not found");

            SagRepository.sletSag(sag);
        }

        public IEnumerable<DTO.Model.Tidsregistrering> hentAlleTidsregistreringer()
        {
            var tidsregistreringer = TidsregistreringRepository.hentAlleTidsregistreringer();
            return tidsregistreringer.Select(t => new Tidsregistrering()
            {
                TidsregistreringId = t.TidsregistreringId,
                StartTid = t.StartTid,
                SlutTid = t.SlutTid,
                MedarbejderInitialer = t.MedarbejderInitialer,
                AfdelingNr = t.AfdelingNr
            });
        }

        public DTO.Model.Tidsregistrering hentTidsregistrering(int tidsregistreringId)
        {
            var tidsregistrering = TidsregistreringRepository.hentTidsregistrering(tidsregistreringId);
            if (tidsregistrering == null)
                throw new KeyNotFoundException("Tidsregistrering not found");

            return new Tidsregistrering()
            {
                TidsregistreringId = tidsregistrering.TidsregistreringId,
                StartTid = tidsregistrering.StartTid,
                SlutTid = tidsregistrering.SlutTid,
                MedarbejderInitialer = tidsregistrering.MedarbejderInitialer,
                AfdelingNr = tidsregistrering.AfdelingNr
            };
        }
        
        public void tilfojTidsregistrering(DTO.Model.Tidsregistrering tidsregistrering)
        {
            tidsregistrering = new Tidsregistrering()
            {
                StartTid = tidsregistrering.StartTid,
                SlutTid = tidsregistrering.SlutTid,
                MedarbejderInitialer = tidsregistrering.MedarbejderInitialer,
                AfdelingNr = tidsregistrering.AfdelingNr
                
            };
            TidsregistreringRepository.tilfojTidsregistrering(tidsregistrering);
        }

        public void opdaterTidsregistrering(DTO.Model.Tidsregistrering tidsregistreringDto)
        {
            var tidsregistrering =
                TidsregistreringRepository.hentTidsregistrering(tidsregistreringDto.TidsregistreringId);
            if (tidsregistrering == null)
                throw new KeyNotFoundException("Tidsregistrering not found");

            TidsregistreringRepository.opdaterTidsregistrering(tidsregistrering);
        }
        
        public void sletTidsregistrering(int tidsregistreringId)
        {
            var tidsregistrering = TidsregistreringRepository.hentTidsregistrering(tidsregistreringId);
            if (tidsregistrering == null)
                throw new KeyNotFoundException("Tidsregistrering not found");

            TidsregistreringRepository.sletTidsregistrering(tidsregistrering);
        }



}
    
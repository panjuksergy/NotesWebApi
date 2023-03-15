using AutoMapper;
using Notes.Application.Common.Mapping;
using Notes.Domain;

namespace Notes.Application.Notes.Queries.GetNoteDetails;

public class NoteDetailsVm : IMapWith<Note>
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Details { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime? EditDate { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Note, NoteDetailsVm>()
            .ForMember(noteVm => noteVm.Title,
                opt => opt.MapFrom(note => note.Title))
            .ForMember(notVm => notVm.Details,
                opt => opt.MapFrom(note => note.Details))
            .ForMember(notVm => notVm.Id,
                opt => opt.MapFrom(note => note.Id))
            .ForMember(notVm => notVm.CreationDate,
                opt => opt.MapFrom(note => note.CreationDate))
            .ForMember(notVm => notVm.EditDate,
                opt => opt.MapFrom(note => note.EditDate));

    }
    
}
@ModelType IEnumerable(Of selati_.eventt)
@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code
<h2 class="form-header">Events</h2>
<h2>
    Pick your favourite activity
</h2>


<div class="grid grid-cols-1 gap-8 mt-8 sm:grid-cols-2 lg:grid-cols-3">
    <a href="@Url.Action("BouldersMarathon")" class="relative flex flex-col h-full pb-4 overflow-hidden bg-white border shadow-md border-cool-gray-100 sm:rounded-lg group focus:outline-none" wire:key="event-77528" id="event-77528" x-on:click="storeScrollPosition('event-77528')">
        <div class="w-full aspect-h-2 aspect-w-3">
            <img src="https://www.roadrunning.co.za/file/edition/Boulders-Marathon-25km-2022/logo/Boulders_Marathon_2022.jpg" class="object-fit" alt="" title="" loading="lazy">
        </div>
        <div class="flex flex-col items-start flex-grow p-4">
            <h2 class="text-xl font-extrabold leading-snug text-gray-800">
                Boulders Marthon 2022
            </h2>
            <div class="mt-3">
                <div class="flex items-center justify-start">
                    <svg viewBox="0 0 20 20" fill="currentColor" class="flex-shrink-0 w-5 h-5 -ml-px text-red-400"><path fill-rule="evenodd" d="M6 2a1 1 0 00-1 1v1H4a2 2 0 00-2 2v10a2 2 0 002 2h12a2 2 0 002-2V6a2 2 0 00-2-2h-1V3a1 1 0 10-2 0v1H7V3a1 1 0 00-1-1zm0 5a1 1 0 000 2h8a1 1 0 100-2H6z" clip-rule="evenodd"></path></svg>
                    <span class="flex-grow ml-2 text-gray-500">Saturday 24 September 2022</span>
                </div>
                <div class="flex items-center justify-start mt-1">
                    <svg viewBox="0 0 20 20" fill="currentColor" class="flex-shrink-0 w-5 h-5 -ml-px text-red-400"><path fill-rule="evenodd" d="M5.05 4.05a7 7 0 119.9 9.9L10 18.9l-4.95-4.95a7 7 0 010-9.9zM10 11a2 2 0 100-4 2 2 0 000 4z" clip-rule="evenodd"></path></svg>
                    <span class="flex-grow ml-2 text-gray-500">Kaapmuiden, Mpumalanga & Mara, Mpumalanga </span>
                </div>
                <div class="flex items-center justify-start mt-1">
                    <svg viewBox="0 0 20 20" fill="currentColor" class="w-5 h-5 -ml-px text-red-400"><path fill-rule="evenodd" d="M12 7a1 1 0 110-2h5a1 1 0 011 1v5a1 1 0 11-2 0V8.414l-4.293 4.293a1 1 0 01-1.414 0L8 10.414l-4.293 4.293a1 1 0 01-1.414-1.414l5-5a1 1 0 011.414 0L11 10.586 14.586 7H12z" clip-rule="evenodd"></path></svg>
                    <span class="flex-grow ml-2 text-gray-500">
                        10km - 25km
                    </span>
                </div>
                <div class="flex items-center justify-start mt-1">
                    <svg viewBox="0 0 20 20" fill="currentColor" class="w-5 h-5 -ml-px text-red-400"><path d="M8.433 7.418c.155-.103.346-.196.567-.267v1.698a2.305 2.305 0 01-.567-.267C8.07 8.34 8 8.114 8 8c0-.114.07-.34.433-.582zM11 12.849v-1.698c.22.071.412.164.567.267.364.243.433.468.433.582 0 .114-.07.34-.433.582a2.305 2.305 0 01-.567.267z"></path><path fill-rule="evenodd" d="M10 18a8 8 0 100-16 8 8 0 000 16zm1-13a1 1 0 10-2 0v.092a4.535 4.535 0 00-1.676.662C6.602 6.234 6 7.009 6 8c0 .99.602 1.765 1.324 2.246.48.32 1.054.545 1.676.662v1.941c-.391-.127-.68-.317-.843-.504a1 1 0 10-1.51 1.31c.562.649 1.413 1.076 2.353 1.253V15a1 1 0 102 0v-.092a4.535 4.535 0 001.676-.662C13.398 13.766 14 12.991 14 12c0-.99-.602-1.765-1.324-2.246A4.535 4.535 0 0011 9.092V7.151c.391.127.68.317.843.504a1 1 0 101.511-1.31c-.563-.649-1.413-1.076-2.354-1.253V5z" clip-rule="evenodd"></path></svg>
                    <span class="flex-grow ml-2 text-gray-500">From R80 - R140</span>
                </div>
                <div class="flex items-center justify-center px-4 mx-4 leading-10 text-white transition-colors duration-150 ease-out bg-gray-800 rounded-md hover:bg-red-800 focus:bg-red-700 focus:outline-none">
                    <span class="font-bold tracking-wide">View Event</span>
                    <svg class="w-4 h-4 ml-2" viewBox="0 0 20 20" fill="currentColor">
                        <path fill-rule="evenodd" d="M10.293 3.293a1 1 0 011.414 0l6 6a1 1 0 010 1.414l-6 6a1 1 0 01-1.414-1.414L14.586 11H3a1 1 0 110-2h11.586l-4.293-4.293a1 1 0 010-1.414z" clip-rule="evenodd"></path>
                    </svg>
                </div>
                
            </div>
        </div>
        </div>

function extractAndLogQueryParameters() {
  const currentUrlParameters = new URLSearchParams(window.location.search);
  const customQueryValue = currentUrlParameters.get('customquery');
  const micAutoplayValue = currentUrlParameters.get('micautoplay');

  if (micAutoplayValue !== null) {
    waitElementThenDo(
      '[data-node-type=speech_dictation_mic_button]',
      (elem) => {
        elem.click();
        waitElementThenDo(".send-button-container button", e => e.click());
      })
    return;
  }

  if (customQueryValue !== null) {
    waitElementThenDo(
      'rich-textarea p',
      (elem) => {
        elem.innerText = customQueryValue
        waitElementThenDo(".send-button-container button", e => e.click());
      }
    )
  }
}
/** @param {string} query 
 *  @param {Function} callback */
function waitElementThenDo(query, callback) {
  const maxRetries = 1000;
  let retriesCount = 0;
  const intervalId = setInterval(() => {
    const elem = document.querySelector(query);
    if (elem) {
      callback(elem);
      clearInterval(intervalId);
    }
    if (++retriesCount >= maxRetries) {

      clearInterval(intervalId);
    }
  }, 100);

}

extractAndLogQueryParameters();
